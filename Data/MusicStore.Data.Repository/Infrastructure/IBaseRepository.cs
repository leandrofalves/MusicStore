using System;
namespace MusicStore.Data.Repository.Infrastructure
{
    public interface IBaseRepository<TEntity>
     where TEntity : class
    {
        TEntity Delete(TEntity entity);
        TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
        System.Collections.Generic.IEnumerable<TEntity> GetAll();
        TEntity GetByID(int id);
        TEntity Insert(TEntity entity);
        IUnitOfWork UnitOfWork { get; }
        void Update(TEntity entity);
    }
}
