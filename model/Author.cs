using System.ComponentModel.DataAnnotations;

namespace Prototype.model;

public class Author
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Book> Books { get; set; }
}