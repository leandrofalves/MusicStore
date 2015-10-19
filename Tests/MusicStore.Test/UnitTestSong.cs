using System;
using System.Linq;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using MusicStore.Entities;
using MusicStore.Data;
using MusicStore.Data.Repository;
using MusicStore.Data.Repository.Infrastructure;

namespace MusicStore.Data.Test
{
    [TestClass]
    public class UnitTestSong
    {
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork = new UnitOfWork();
        }
       
        [TestMethod]
        public void QueryAllSong()
        {
            using (IRepositorySong repository = new RepositorySong(_unitOfWork)) 
            {
                var list = repository.GetAll().ToList();

                foreach (var item in list)
                {
                    Trace.TraceInformation("Genre {0} - {1}: ", item.SongID, item.Name);
                }
            }

        }


    }
}
