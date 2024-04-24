

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(string id);
    T Add(T entity);
    T Update(T entity);
    T Delete(string id);
    void Save();
    bool Exists(string id);
    IEnumerable<T> Find(Func<T, bool> predicate);
    T Get(Func<T, bool> predicate);
    
}


public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private readonly AppDBContext _context;

    public Repository(AppDBContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(string id)
    {
        return _context.Set<T>().Find(id);
    }

    public T Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
        return entity;
    }

    public T Delete(string id)
    {
        var entity = _context.Set<T>().Find(id);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        return entity;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public bool Exists(string id)
    {
        return _context.Set<T>().Any(e => e.Id == id);
    }

    public IEnumerable<T> Find(Func<T, bool> predicate)
    {
        return _context.Set<T>().Where(predicate).ToList();
    }

    public T Get(Func<T, bool> predicate)
    {
        return _context.Set<T>().SingleOrDefault(predicate);
    }
}

public interface IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
}



