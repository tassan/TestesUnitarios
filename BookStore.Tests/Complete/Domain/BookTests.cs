using BookStore.Domain.Models;

namespace BookStore.Tests.Complete.Domain;

[Trait("Category", "Unit")]
public class BookTests
{
    [Fact]
    public void Should_CreateBook()
    {
        var book = new Book("It", "Stephen King");
        Assert.Equal("It", book.Title);
        Assert.Equal("Stephen King", book.Author);
    }
    
    [Fact]
    public void Should_ThrowException_When_TitleIsNull()
    {
        Assert.Throws<ArgumentException>(() => new Book(null, "Stephen King"));
    }
    
    [Fact]
    public void Should_ThrowException_When_AuthorIsNull()
    {
        Assert.Throws<ArgumentException>(() => new Book("It", null));
    }
    
    [Fact]
    public void Should_ThrowException_When_TitleIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => new Book("", "Stephen King"));
    }
    
    [Fact]
    public void Should_ThrowException_When_AuthorIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => new Book("It", ""));
    }
}