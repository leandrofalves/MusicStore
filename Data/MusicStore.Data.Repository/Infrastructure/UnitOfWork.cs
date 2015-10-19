using System;
using System.Data.Entity;

namespace MusicStore.Data.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        //private TransactionScope _transaction;
        private readonly MusicStoreEntityContext _db;
        private DbContextTransaction _transaction;

        public MusicStoreEntityContext DB 
        { 
            get { return _db; }
        }

        public UnitOfWork() 
        {
            _db = new MusicStoreEntityContext();
        }

        public void BeginTransaction() 
        {
            //_transaction = new TransactionScope();
            _transaction =  _db.Database.BeginTransaction();
        }

        public void Roolback() 
        {
            if (_transaction != null) _transaction.Rollback();
        }

        public void Commit() 
        {
            _db.SaveChanges();
            if (_transaction !=null) _transaction.Commit();
        }

        public void Dispose()
        {
            if (_transaction != null) _transaction.Dispose();
            if (_db != null) _db.Dispose();

        }

    }
}
