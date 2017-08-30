using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SuperCoolApp.Domain.IRepository;

namespace SuperCoolApp.DAL.Repository
{
  public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    private readonly DbSet<TEntity> _entities;

    protected Repository(CodemyDbContext context)
    {
      _entities = context.Set<TEntity>();
    }

    public IEnumerable<TEntity> GetAll()
    {
      var d = _entities.ToList();

      return _entities.ToList();
    }


    public TEntity Add(TEntity entity)
    {
      _entities.Add(entity);
      return entity;
    }

    public void Delete(TEntity entity)
    {
      _entities.Remove(entity);
    }

    //public TEntity GetById(int id)
    //{
    //    return _entities.Find(id);
    //}
  }
}

