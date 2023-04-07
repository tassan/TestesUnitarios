using BookStore.Domain.Interface;
using Microsoft.Extensions.Logging;

namespace BookStore.Infra;

public class GenericRepositoryImp<T> : IRepository<T> where T : class
{
    private readonly ILogger<GenericRepositoryImp<T>> _logger;

    protected GenericRepositoryImp(ILogger<GenericRepositoryImp<T>> logger)
    {
        _logger = logger;
    }

    public void Add(T entity)
    {
        _logger.LogInformation("Adding Entity {Entity}", entity);
        _logger.LogInformation("Entity {Entity} added", entity);
    }

    public void Delete(T entity)
    {
        _logger.LogInformation("Deleting Entity {Entity}", entity);
        _logger.LogInformation("Entity {Entity} deleted", entity);
    }

    public void Update(T entity)
    {
        _logger.LogInformation("Updating Entity {Entity}", entity);
        _logger.LogInformation("Entity {Entity} updated", entity);
    }

    public T? GetById(int id)
    {
        _logger.LogInformation("Getting Entity by id {Id}", id);
        _logger.LogInformation("Entity {Id} got", id);
        
        return null;
    }

    public IEnumerable<T> GetAll()
    {
        _logger.LogInformation("Getting all entities");
        _logger.LogInformation("All entities got");
        
        return new List<T>();
    }
}