using Microsoft.EntityFrameworkCore;
using Prototype.data;
using Prototype.model;

namespace Prototype.Types.Query;

[QueryType]
public static class BookQueries
{
    [UseFiltering]
    public static IQueryable<Book> GetBooksIQueryable(
        [Service] PrototypeDbContext context) =>
        context.Books;

    [UseFiltering]
    public static async Task<IQueryable<Book>> GetBooksInMemoryQueryable([Service] PrototypeDbContext context) =>
        (await context.Books.ToListAsync()).AsQueryable();

    [UseFiltering]
    public static async Task<IEnumerable<Book>> GetBooksInMemoryEnumerable([Service] PrototypeDbContext context) =>
        await context.Books.ToListAsync();
}