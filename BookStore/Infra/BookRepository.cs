using BookStore.Domain.Models;
using BookStore.Infra.Interfaces;
using Microsoft.Extensions.Logging;

namespace BookStore.Infra;

internal class BookRepository : GenericRepositoryImp<Book>, IBookRepository
{
    private readonly ILogger<BookRepository> _logger;

    public BookRepository(ILogger<BookRepository> logger) : base(logger)
    {
        _logger = logger;
    }

    public Book GetByTitle(string? bookTitle)
    {
        _logger.LogInformation("Getting book by title");
        return new Book(bookTitle, "Author");
    }

    public Shelf GetShelfByName(string shelfName)
    {
        _logger.LogInformation("Getting shelf by name");
        return new Shelf(shelfName);
    }
}