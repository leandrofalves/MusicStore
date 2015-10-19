using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Business
{
    public interface IMusicStoreComponent: IDisposable
    {
        System.Collections.Generic.IList<MusicStore.Entities.Artist> GetArtists();
        System.Collections.Generic.IList<MusicStore.Entities.Genre> GetGenres();
    }
}
