﻿namespace BookStore.Domain.Interface;

public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T? GetById(int id);
    IEnumerable<T> GetAll();
}