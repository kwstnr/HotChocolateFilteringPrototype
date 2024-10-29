using Microsoft.EntityFrameworkCore;
using Prototype.data;
using Prototype.model;

namespace Prototype.DataLoaders;

internal static class AuthorDataLoaders
{
    [DataLoader]
    internal static async Task<IReadOnlyDictionary<Guid, Author>> GetAuthorByBookId(
        IReadOnlyList<Guid> bookIds,
        PrototypeDbContext context,
        CancellationToken cancellationToken) => await context.Books
        .Where(b => bookIds.Contains(b.Id))
        .Select(b => new
        {
            Key = b.Id,
            Author = b.Author
        })
        .ToDictionaryAsync(g => g.Key, g => g.Author, cancellationToken);
}