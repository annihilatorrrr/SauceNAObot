﻿// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the GNU General Public License v3.0, See LICENCE in the project root for license information.

using Microsoft.Extensions.Logging;
using SauceNAO.Core.API;
using SauceNAO.Core.Entities;
using SauceNAO.Core.Models;
using SauceNAO.Core.Resources;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableMethods.FormattingOptions;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.UpdatingMessages;
using File = System.IO.File;

namespace SauceNAO.Core;

public partial class SauceNaoBot : AsyncTelegramBotBase<SnaoBotProperties>
{
	private async Task UpdateSearchMessageAsync(Message message, string newtext, [Optional] InlineKeyboardMarkup keyboard)
	{
		EditMessageTextArgs args = new(string.IsNullOrEmpty(newtext) ? "unknown name" : newtext)
		{
			ChatId = message.Chat.Id,
			MessageId = message.MessageId,
			ParseMode = ParseMode.HTML,
			DisableWebPagePreview = true,
			ReplyMarkup = keyboard
		};

		try
		{
			await this.Api.EditMessageTextAsync<Message>(args).ConfigureAwait(false);
		}
		catch (BotRequestException exp)
		{
			this.OnBotExceptionAsync(exp, default).Wait();
		}
		catch (Exception exp)
		{
			this.OnExceptionAsync(exp, default).Wait();
		}
	}
	private bool TryGetFilePath(TargetMedia targetMedia, out string ext)
	{
		var okey = true;
		ext = string.Empty;
		try
		{
			var file = this.Api.GetFile(targetMedia.TargetFileId);
			targetMedia.FilePath = string.Format(BotClient.BaseFilesUrl, this.Api.Token, file.FilePath);
			ext = Path.GetExtension(file.FilePath);
		}
		catch (BotRequestException exp)
		{
			okey = false;
			this.OnBotExceptionAsync(exp, default).Wait();
		}
		return okey;
	}

	[SuppressMessage("Usage", "CA2253:Named placeholders should not be numeric values")]
	private async Task<bool> TryDownloadAsync(TargetMedia target, CancellationToken cancellationToken)
	{
		var okey = true;
		if (this.TryGetFilePath(target, out string ext))
		{
			var fileName = target.FileUniqueId + ext;
			var tempFile = this._db.Files.GetFile(target.FileUniqueId);
			if (tempFile == default)
			{
				var fileBytes = await httpClient.GetByteArrayAsync(target.FilePath, cancellationToken).ConfigureAwait(false);
				try
				{
					var item = new CachedTelegramFile(target.FileUniqueId, fileName, target.ContentType, fileBytes);
					await this._db.Files.InsertAsync(item, cancellationToken).ConfigureAwait(false);
					target.TemporalFilePath = string.Format(this.Properties.TempFilesUrl!, target.FileUniqueId);
				}
				catch (Exception e)
				{
					okey = false;
					this._logger.LogError("Can't insert new temporal file. Error message. {0}", e.InnerException?.Message ?? e.Message);
				}
			}
			else
			{
				target.TemporalFilePath = string.Format(this.Properties.TempFilesUrl!, target.FileUniqueId);
			}
		}
		else
		{
			okey = false;
		}
		return okey;
	}
	private async Task<bool> TryGetImageFromVideo(TargetMedia targetMedia, Message message, CancellationToken cancellationToken)
	{
		if (string.IsNullOrEmpty(targetMedia.FilePath))
		{
			if (!this.TryGetFilePath(targetMedia, out _))
			{
				return false;
			}
		}
		var fileName = $"{targetMedia.FileUniqueId}.jpg";
		string outputPath = $"{Path.GetTempPath()}{fileName}";
		var tempFile = this._db.Files.GetFile(targetMedia.FileUniqueId);

		if (tempFile == default)
		{
			var ffmpegArgs = "-vf \"select=eq(n\\,0)\" -frames:v 1";
			if (this.Properties.FFmpeg!.Run(targetMedia.FilePath, outputPath, ffmpegArgs))
			{
				try
				{
					targetMedia.TemporalFilePath = string.Format(this.Properties.TempFilesUrl!, targetMedia.FileUniqueId);
					var fileBytes = await File.ReadAllBytesAsync(outputPath, cancellationToken).ConfigureAwait(false);
					var item = new CachedTelegramFile(targetMedia.FileUniqueId, fileName, targetMedia.ContentType, fileBytes);
					await this._db.Files.InsertAsync(item, cancellationToken).ConfigureAwait(false);
				}
				catch (Exception)
				{
					var text = MSG.FailedConvertFile(this.Language);
					await this.UpdateSearchMessageAsync(message, text);
					throw;
				}
			}
			else
			{
				return false;
			}
		}
		else
		{
			targetMedia.TemporalFilePath = string.Format(this.Properties.TempFilesUrl!, targetMedia.FileUniqueId);
		}
		return true;
	}

	[SuppressMessage("Usage", "CA2253:Named placeholders should not be numeric values")]
	private async Task<SauceBowl> CookSauceAsync(string filePath, CancellationToken cancellationToken)
	{
		SauceBowl sauce;
		try
		{
			// Select api key
			var snao = string.IsNullOrEmpty(this.User.ApiKey)
				? this.Properties.SnaoService // Shared Api Key
				: new SauceNaoApiService(OutputType.JsonApi, this.User.ApiKey, db: 999, dedupe: Dedupe.AllImplementedDedupeMethodsSuchAsBySeriesName); // user Api Key
																																					   // Get raw sauce
			var response = await snao.SearchAsync(filePath, cancellationToken).ConfigureAwait(false);
			// Cook sauce
			sauce = new SauceBowl(response);
		}
		catch (SearchResponseException exp)
		{
			this._logger.LogError("Cooking Error: {0}", exp.InnerException?.Message ?? exp.Message);
			// Cook sauce
			sauce = new SauceBowl(exp);
		}
		return sauce;
	}
}
