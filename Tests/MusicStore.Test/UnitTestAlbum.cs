using System;
using System.Linq;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MusicStore.Data;
using MusicStore.Data.Repository;
using MusicStore.Data.Repository.Infrastructure;

namespace MusicStore.Data.Test
{
    [TestClass]
    public class UnitTestAlbum
    {
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork = new UnitOfWork();
        }

        [TestMethod]
        public void QueryAllAlbum()
        {
            using (IRepositoryAlbum repository = new RepositoryAlbum(_unitOfWork))
            {
                var list = repository.GetAll();

                foreach (var item in list)
                {
                    Trace.TraceInformation("Album: {0} - {1} ", item.AlbumID, item.Title);
                }
            }

        }


    }
}
