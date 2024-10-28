using Microsoft.EntityFrameworkCore;
using Prototype.data;
using Prototype.model;

namespace Prototype.Types.Nodes;

[ObjectType<Book>]
public static partial class BookNode
{
    static partial void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Ignore(b => b.AuthorId);
    }

    public static async Task<Author?> GetAuthorAsync([Parent] Book book, [Service] PrototypeDbContext context,
        CancellationToken cancellationToken) =>
        await context.Authors.FirstOrDefaultAsync(a => a.Id == book.AuthorId, cancellationToken);
}