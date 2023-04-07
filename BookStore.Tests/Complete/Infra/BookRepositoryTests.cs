using BookStore.Domain.Models;
using BookStore.Infra.Interfaces;


namespace BookStore.Tests.Complete.Infra;

public class BookRepositoryTests
{
    public BookRepositoryTests(Mock<IBookRepository> bookRepositoryMock)
    {
        BookRepositoryMock = bookRepositoryMock;
    }

    private Mock<IBookRepository> BookRepositoryMock { get; set; }

    
    [Fact]
    public void Should_Add_Book()
    {
        // Arrange
        BookRepositoryMock = new Mock<IBookRepository>();
        var book = new Book("Test Book", "Test Author");
        BookRepositoryMock.Setup(x => x.Add(book));
        
        // Act
        BookRepositoryMock.Object.Add(book);
        
        // Assert
        BookRepositoryMock.Verify(x => x.Add(book), Times.Once);
    }
    
}