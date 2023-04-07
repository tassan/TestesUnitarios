namespace BookStore.Domain.Models;

public class Book
{
    public Guid Id { get; set; }
    public string? Title { get; set; } = null!;
    public string? Author { get; set; } = null!;

    public Book()
    {
        Id = Guid.NewGuid();
    }
    
    public Book(string? title, string? author)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be null or empty", nameof(title));

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be null or empty", nameof(author));

        Id = Guid.NewGuid();
        Title = title;
        Author = author;
    }
}