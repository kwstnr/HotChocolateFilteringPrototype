using Microsoft.EntityFrameworkCore;
using Prototype.data;
using Prototype.model;

namespace Prototype.Types.Query;

[QueryType]
public static class AuthorQueries
{
    [UseFiltering]
    public static async Task<IEnumerable<Author>> GetAuthorsAsync([Service] PrototypeDbContext context, CancellationToken cancellationToken) => await context.Authors.ToListAsync(cancellationToken);
}