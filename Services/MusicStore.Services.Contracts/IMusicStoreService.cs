using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.ServiceModel;

using MusicStore.Entities;
using MusicStore.Entities.Services;

namespace MusicStore.Services.Contracts
{
    [ServiceContract]
    
    [ServiceKnownType(typeof(IList<Artist>))]
    [ServiceKnownType(typeof(List<Artist>))]
    [ServiceKnownType(typeof(List<Genre>))]
    [ServiceKnownType(typeof(IList<Artist>))]
    public interface IMusicStoreService
    {
        [OperationContract]
        ServiceReturn GetArtist();

        [OperationContract]
        ServiceReturn GetGenres();

    }
}
