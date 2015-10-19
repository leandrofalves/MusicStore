using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicStore.Entities;
using MusicStore.Data.Repository;
using MusicStore.Data.Repository.Infrastructure;

namespace MusicStore.Data
{
    public class RepositoryAlbum:BaseRepository<Album>, IRepositoryAlbum
    {

        public RepositoryAlbum(IUnitOfWork unit)
            : base(unit)
        { 
        }

        void IDisposable.Dispose() 
        {
            base.Dispose();
        }
    }
}
