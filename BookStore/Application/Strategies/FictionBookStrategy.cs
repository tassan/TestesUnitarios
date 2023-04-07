using BookStore.Application.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infra.Interfaces;
using Microsoft.Extensions.Logging;

namespace BookStore.Application.Strategies;

public class FictionBookStrategy : IFictionBookStrategy
{
    private readonly ILogger<FictionBookStrategy> _logger;
    private readonly IBookRepository _bookRepository;

    public FictionBookStrategy(ILogger<FictionBookStrategy> logger, IBookRepository bookRepository)
    {
        _logger = logger;
        _bookRepository = bookRepository;
    }

    public void CreateFictionBook(string? title, string? author)
    {
        _logger.LogInformation("Creating fiction book");
        var book = new Book(title, author);
        
        _logger.LogInformation("Saving fiction book");
        _bookRepository.Add(book);
        
        _logger.LogInformation("Fiction book created");
    }

    public void AddFictionBookToShelf(string shelfName, string? bookTitle)
    {
        _logger.LogInformation("Adding fiction book to shelf");
        var book = _bookRepository.GetByTitle(bookTitle);
        var shelf = _bookRepository.GetShelfByName(shelfName);
        
        shelf.Add(book);
        
        _logger.LogInformation("Fiction book added to shelf");
    }
}