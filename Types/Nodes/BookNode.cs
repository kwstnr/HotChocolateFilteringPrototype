using Microsoft.EntityFrameworkCore;
using Prototype.data;
using Prototype.DataLoaders;
using Prototype.model;

namespace Prototype.Types.Nodes;

[ObjectType<Book>]
public static partial class BookNode
{
    static partial void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Ignore(b => b.AuthorId);
    }

    public static async Task<Author?> GetAuthorAsync([Parent] Book book,
        [Service] IAuthorByBookIdDataLoader authorByBookIdDataLoader, CancellationToken cancellationToken) =>
        await authorByBookIdDataLoader.LoadAsync(book.Id, cancellationToken);
}