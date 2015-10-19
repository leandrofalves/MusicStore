using System;
using MusicStore.Data;

namespace MusicStore.Data.Repository.Infrastructure
{       
    public interface IUnitOfWork: IDisposable
    {
        MusicStoreEntityContext DB { get; }
        void BeginTransaction();
        void Commit();
        void Roolback();
    }
}
