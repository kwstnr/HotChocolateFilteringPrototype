using System.ComponentModel.DataAnnotations;

namespace Prototype.model;

public class Book
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
}