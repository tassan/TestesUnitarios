using BookStore.Domain.Exceptions;

namespace BookStore.Domain.Models;

public class Shelf
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    private IEnumerable<Book> Books { get; set; }

    public Shelf()
    {
        Books = new List<Book>();
    }

    public Shelf(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void Add(Book book)
    {
        if (Books.Any(b => b.Id == book.Id) || book is null)
            throw new ShelfException("Book already exists on shelf",
                new ArgumentNullException(nameof(book)));

        ((List<Book>)Books).Add(book);
    }

    public void Remove(Book book)
    {
        if (Books.All(b => b.Id != book.Id) || book is null)
            throw new ShelfException("Book already exists on shelf",
                new ArgumentNullException(nameof(book)));


        ((List<Book>)Books).Remove(book);
    }

    public List<Book> GetAllBooks()
    {
        if (Books == null)
            throw new ShelfException("No books on shelf");

        return Books.ToList();
    }

    public Book GetBookById(Guid id)
    {
        if (Books == null)
            throw new ShelfException("No books on shelf");

        return Books.First(b => b.Id == id);
    }

    public int Count() => Books.Count();
}