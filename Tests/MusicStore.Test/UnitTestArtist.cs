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
    public class UnitTestArtist
    {
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork = new UnitOfWork();
        }
       
        [TestMethod]
        public void QueryAllArtist()
        {
            using (IRepositoryArtist repository = new RepositoryArtist(_unitOfWork)) 
            {
                var list = repository.GetAll().ToList();

                foreach (var item in list)
                {
                    Trace.TraceInformation("Genre {0} - {1}: ", item.ArtistID, item.Name);
                }
            }

        }
    }
}
