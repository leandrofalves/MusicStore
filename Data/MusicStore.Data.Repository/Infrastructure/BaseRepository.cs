using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace MusicStore.Data.Repository.Infrastructure
{
    public abstract class BaseRepository<TEntity>:IBaseRepository<TEntity> where TEntity : class
        
    {
        private readonly IUnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork
        {     
            get { return _unitOfWork; }
        }

        public BaseRepository(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public TEntity Insert(TEntity entity)
        {
            return _unitOfWork.DB.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.DB.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public TEntity Delete(TEntity entity)
        {
            return _unitOfWork.DB.Set<TEntity>().Remove(entity);
        }

        public TEntity GetByID(int id)
        {
            return _unitOfWork.DB.Set<TEntity>().Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _unitOfWork.DB.Set<TEntity>().FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _unitOfWork.DB.Set<TEntity>().ToList();
        }

        public void Dispose() 
        {
            if (_unitOfWork != null)
                _unitOfWork.DB.Dispose();
        }

    }
}
