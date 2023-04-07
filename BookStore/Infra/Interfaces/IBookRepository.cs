using BookStore.Domain.Interface;
using BookStore.Domain.Models;

namespace BookStore.Infra.Interfaces;

public interface IBookRepository : IRepository<Book>
{
    Book GetByTitle(string? bookTitle);
    Shelf GetShelfByName(string shelfName);
}