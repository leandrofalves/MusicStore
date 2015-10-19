using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MusicStore.Entities;
using MusicStore.Data;
using MusicStore.Data.Repository;
using MusicStore.Data.Repository.Infrastructure;

namespace MusicStore.Business
{
    public class MusicStoreComponent:IMusicStoreComponent
    {
        IUnitOfWork _unitOfWork;

        public MusicStoreComponent():this(new UnitOfWork()) 
        { 

        }

        public MusicStoreComponent(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }

        public IList<Artist> GetArtists()
        {
            IRepositoryArtist repository = new RepositoryArtist(_unitOfWork);
            
             var list =  repository.GetAll().ToList();

             return list;
        }

        public IList<Genre> GetGenres() 
        {
            //Isso não funciona, o Dispose é acionadado antes
            using (IRepositoryGenre repository = new RepositoryGenre(_unitOfWork))
            {
                return repository.GetAll().ToList();
            }
        }

        void IDisposable.Dispose()
        {
            if (_unitOfWork != null) _unitOfWork.Dispose();
        }

    }
}
