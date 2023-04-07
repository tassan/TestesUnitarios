using BookStore.Domain.Interface;

namespace BookStore.Application.Interfaces;

public interface IFictionBookStrategy
{
    void CreateFictionBook(string? title, string? author);
    void AddFictionBookToShelf(string shelfName, string? bookTitle);
}