using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MusicStore.Entities;
using MusicStore.Data;


namespace MusicStore.Data.Repository
{
    public class MusicStoreRepository:IRepository
    {
        private readonly MusicStoreEntityContext _context;

        public MusicStoreRepository() 
        {
            _context = new MusicStoreEntityContext();
        
        }
        
        public IQueryable<T> All<T>() where T : class
        {
            return _context.Set<T>();
        }

        public IQueryable<T> AllIncluding<T>(params Expression<Func<T, object>>[] include) where T : class
        {
            IQueryable<T> ret = _context.Set<T>();

            foreach (var item in include)
            {
                ret = ret.Include(item);
            }

            return ret;

        }

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }
    }
}