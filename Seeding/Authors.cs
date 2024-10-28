using Prototype.model;

namespace Prototype.Seeding;

public static class Authors
{
    public static IEnumerable<Author> AuthorsToSeed => new List<Author>
    {
        new Author
        {
            Id = Guid.Parse("040b979f-204c-4cdd-8d99-20d77ea3c0dd"),
            Name = "Author 1"
        },
        new Author
        {
            Id = Guid.Parse("a48658ba-e41c-4634-9846-89df0fd6a953"),
            Name = "Author 2"
        }
    };
}