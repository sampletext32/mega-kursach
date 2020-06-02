using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IArtistRepository : IAddEntity<Artist>, IGetEntity<Artist>, IUpdateEntity<Artist>,
        IRemoveEntity<Artist>, ICanGetAll<Artist>
    {
        IList<Artist> GetByAlbum(Album album);
        IList<Artist> GetByDistributor(Distributor distributor);
    }
}