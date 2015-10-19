using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.ServiceModel;


using MusicStore.Business;
using MusicStore.Entities;
using MusicStore.Entities.Services;
using MusicStore.Services.Contracts;

namespace MusicStore.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple, MaxItemsInObjectGraph= int.MaxValue) ]
    public class MusicStoreService: BaseService, IMusicStoreService
    {
        IMusicStoreComponent _component ;

        public MusicStoreService() 
        {
            _component = new MusicStoreComponent();
        }

        public ServiceReturn GetArtist()
        {
            try
            {
                return new ServiceReturn("OK", _component.GetArtists(), null);
            }
            catch (Exception ex)
            {
                LogServiceException("Erro recuperando lista de Artistas", ex);

                return new ServiceReturn("ERROR", null, FormatException(ex));
            }
        }

        public ServiceReturn GetGenres()
        {
            try
            {
                return new ServiceReturn("OK", _component.GetGenres(), null);
            }
            catch (Exception ex)
            {
                LogServiceException("Erro recuperando lista de Artistas", ex);

                return new ServiceReturn("ERROR", null, FormatException(ex));
            }
        }
    }
}
