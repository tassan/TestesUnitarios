using BookStore.Domain.Exceptions;
using BookStore.Domain.Models;

namespace BookStore.Tests.Complete.Domain;

[Trait("Category", "Unit")]
public class ShelfTests
{
    [Fact]
    public void Should_AddBook()
    {
        var shelf = new Shelf();
        shelf.Add(new Book("The Hobbit", "J.R.R. Tolkien"));
        Assert.Equal(1, shelf.Count());
    }
    
    [Fact]
    public void Should_RemoveBook()
    {
        var shelf = new Shelf();
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        shelf.Add(book);
        shelf.Remove(book);
        Assert.Equal(0, shelf.Count());
    }
    
    [Fact]
    public void Should_GetAllBooks()
    {
        var shelf = new Shelf();
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        shelf.Add(book);
        var books = shelf.GetAllBooks();
        Assert.Single(books);
    }
    
    [Fact]
    public void Should_GetBookById()
    {
        var shelf = new Shelf();
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        shelf.Add(book);
        var bookById = shelf.GetBookById(book.Id);
        Assert.Equal(book, bookById);
    }
    
    [Fact]
    public void Should_ThrowException_When_AddingBookThatAlreadyExists()
    {
        var shelf = new Shelf();
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        shelf.Add(book);
        Assert.Throws<ShelfException>(() => shelf.Add(book));
    }
    
    [Fact]
    public void Should_ThrowException_When_RemovingBookThatDoesNotExist()
    {
        var shelf = new Shelf();
        var book = new Book("The Hobbit", "J.R.R. Tolkien");
        Assert.Throws<ShelfException>(() => shelf.Remove(book));
    }

    [Fact]
    public void Should_ThrowException_When_AddingNullBook()
    {
        var shelf = new Shelf();
        Assert.Throws<ShelfException>(() => shelf.Add(null!));
    }
    
    [Fact]
    public void Should_ThrowException_When_RemovingNullBook()
    {
        var shelf = new Shelf();
        Assert.Throws<ShelfException>(() => shelf.Remove(null!));
    }
}