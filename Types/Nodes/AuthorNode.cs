using Prototype.data;
using Prototype.model;

namespace Prototype.Types.Nodes;

[ObjectType<Author>]
public static partial class AuthorNode
{
    public static IQueryable<Book> GetBooks([Parent] Author author, [Service] PrototypeDbContext context) =>
        context.Books.Where(b => b.AuthorId == author.Id);
}