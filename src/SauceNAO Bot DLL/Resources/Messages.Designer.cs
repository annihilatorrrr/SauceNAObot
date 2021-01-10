﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SauceNAO.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SauceNAO.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This bot provides you with an interface to use &lt;a href=&quot;https://saucenao.com/&quot;&gt;SauceNAO&lt;/a&gt;&apos;s reverse image search engine.
        ///Send me an image (image, GIF or a sticker) and I&apos;ll try to reverse search using the SauceNAO API.
        ///If you have an saucenao account, then you can use your own &lt;b&gt;ApiKey&lt;/b&gt; to make your sauces. Use &lt;i&gt;/help apikey&lt;/i&gt; to get more information..
        /// </summary>
        internal static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this feature to block the sauce of photos sent by bots in your group chats. To enable/disable Anticheats use /anticheats on|off.
        /// </summary>
        internal static string Anticheats {
            get {
                return ResourceManager.GetString("Anticheats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bot {0} was added to the exception list. To remove the bot, reply to it with the /delex command..
        /// </summary>
        internal static string AnticheatsAdded {
            get {
                return ResourceManager.GetString("AnticheatsAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bot {0} was removed from the exception list..
        /// </summary>
        internal static string AnticheatsDeleted {
            get {
                return ResourceManager.GetString("AnticheatsDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ups, no cheating, my friend..
        /// </summary>
        internal static string AnticheatsMessage {
            get {
                return ResourceManager.GetString("AnticheatsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anticheats has been disabled..
        /// </summary>
        internal static string AnticheatsOff {
            get {
                return ResourceManager.GetString("AnticheatsOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Anticheats has been enabled. To add bots to the exception list, respond to them with the /addex command..
        /// </summary>
        internal static string AnticheatsOn {
            get {
                return ResourceManager.GetString("AnticheatsOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SauceNAO is very busy. Please try again later or use the /temp command to get a temporary link to the image and search for the image yourself..
        /// </summary>
        internal static string Busy {
            get {
                return ResourceManager.GetString("Busy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation was cancelled..
        /// </summary>
        internal static string Cancelled {
            get {
                return ResourceManager.GetString("Cancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string Confirm {
            get {
                return ResourceManager.GetString("Confirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You need to reply to an image file (image, GIF or a sticker).
        /// </summary>
        internal static string EmptyRequest {
            get {
                return ResourceManager.GetString("EmptyRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to convert file to a supported file..
        /// </summary>
        internal static string FailedConvertFile {
            get {
                return ResourceManager.GetString("FailedConvertFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating temporary link....
        /// </summary>
        internal static string GeneratingTmpUrl {
            get {
                return ResourceManager.GetString("GeneratingTmpUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Send me an image file (image, GIF or a sticker) to find its source right now.
        ///&lt;i&gt;If I&apos;m in a group, reply to a image with /sauce or /source&lt;/i&gt;.
        /// </summary>
        internal static string Help {
            get {
                return ResourceManager.GetString("Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SauceNAObot&apos;s daily search limit is constantly exceeded by users. 
        ///Using your personal &lt;b&gt; API Key &lt;/b&gt; will help you perform more reverse searches without having to worry about other users.
        ///To start using your own &lt;b&gt; API Key &lt;/b&gt; use the command /setapikey followed by the key. Ex: _&lt;i&gt;/setapikey APIKEY&lt;/i&gt;.
        /// </summary>
        internal static string HelpApikey {
            get {
                return ResourceManager.GetString("HelpApikey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Watch your search history.
        ///Use /clean command to delete it..
        /// </summary>
        internal static string History {
            get {
                return ResourceManager.GetString("History", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the search history?.
        /// </summary>
        internal static string HistoryDelConfirm {
            get {
                return ResourceManager.GetString("HistoryDelConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your history has been erased..
        /// </summary>
        internal static string HistoryErased {
            get {
                return ResourceManager.GetString("HistoryErased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That doesn&apos;t look like a photo file..
        /// </summary>
        internal static string InvalidPhoto {
            get {
                return ResourceManager.GetString("InvalidPhoto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not specified sufficient parameters to use this function..
        /// </summary>
        internal static string MissingParams {
            get {
                return ResourceManager.GetString("MissingParams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No sauce found. Maybe try &lt;a href=&quot;{0}&quot;&gt;Google Reverse Search&lt;/a&gt; or &lt;a href=&quot;{0}&quot;&gt;Yandex&lt;/a&gt; instead? or see on &lt;a href=&quot;{0}&quot;&gt;SauceNAO website&lt;/a&gt; to see all the results..
        /// </summary>
        internal static string NotFound {
            get {
                return ResourceManager.GetString("NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Character.
        /// </summary>
        internal static string ResultCharacter {
            get {
                return ResourceManager.GetString("ResultCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Characters.
        /// </summary>
        internal static string ResultCharacters {
            get {
                return ResourceManager.GetString("ResultCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creator.
        /// </summary>
        internal static string ResultCreator {
            get {
                return ResourceManager.GetString("ResultCreator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Material.
        /// </summary>
        internal static string ResultMaterial {
            get {
                return ResourceManager.GetString("ResultMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Part.
        /// </summary>
        internal static string ResultPart {
            get {
                return ResourceManager.GetString("ResultPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time.
        /// </summary>
        internal static string ResultTime {
            get {
                return ResourceManager.GetString("ResultTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Year.
        /// </summary>
        internal static string ResultYear {
            get {
                return ResourceManager.GetString("ResultYear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searching....
        /// </summary>
        internal static string Searching {
            get {
                return ResourceManager.GetString("Searching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done! Check your &lt;a href=&quot;{0}&quot;&gt;temp url&lt;/a&gt;.
        /// </summary>
        internal static string TmpUrlDone {
            get {
                return ResourceManager.GetString("TmpUrlDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search could not be performed. The file size is too large..
        /// </summary>
        internal static string TooBigFile {
            get {
                return ResourceManager.GetString("TooBigFile", resourceCulture);
            }
        }
    }
}