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
    public class UnitTestGenre
    {
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork = new UnitOfWork();
        }
       
        [TestMethod]
        public void QueryAllGenre()
        {
            using (IRepositoryGenre repository = new RepositoryGenre(_unitOfWork)) 
            {
                var list = repository.GetAll().ToList();

                foreach (var item in list)
                {
                    Trace.TraceInformation("Genre {0} - {1}: ", item.GenreID, item.Name);
                }
            }

        }

        [TestMethod]
        public void QueryAllGenreIncludingAlbums()
        {

            //using (IRepositoryGenre repGenre = new RepositoryGenre(_unitOfWork)) 
            //{ 
            //    var list = repGenre.
            
            
            
            //}






            //var list = _repository.AllIncluding<Genre>(p => p.Albums).ToList();

            //foreach (var item in list)
            //{
            //    Trace.TraceInformation("Genre : {0} - {1} ", item.GenreID, item.Name);
            //    Trace.TraceInformation("Total Albuns: {0} ", item.Albums.Count());
            //}
        }





    }
}
