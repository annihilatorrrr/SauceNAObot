// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the GNU General Public License v3.0, See LICENCE in the project root for license information.

using SauceNAO.Domain.Entities.UserAggregate;
using System.Linq.Expressions;

namespace SauceNAO.Domain.Specifications;

/// <summary>
/// Represents a specification to filter users by their unique identifier.
/// </summary>
/// <param name="userId">Unique identifier of the user.</param>
public class UserSpecification(long userId) : SpecificationBase<TelegramUser>
{
    /// <inheritdoc/>
    protected override Expression<Func<TelegramUser, bool>> Expression =>
        user => user.UserId == userId;
}
