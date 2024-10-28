using Prototype.model;

namespace Prototype.Seeding;

public static class Books
{
    public static IEnumerable<Book> BooksToSeed => new List<Book>
    {
        new Book
        {
            Id = Guid.Parse("b56a4853-86eb-4ae8-b0b0-fef35a2d870f"),
            Title = "Book 1",
            AuthorId = Guid.Parse("040b979f-204c-4cdd-8d99-20d77ea3c0dd")
        },
        new Book
        {
            Id = Guid.Parse("461d585b-248e-41a7-b154-1ddd5addda4a"),
            Title = "Book 2",
            AuthorId = Guid.Parse("a48658ba-e41c-4634-9846-89df0fd6a953")
        }
    };
}