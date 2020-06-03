using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtistRepository : ICanAddEntity<Artist>, ICanGetEntity<Artist>, ICanUpdateEntity<Artist>,
        ICanRemoveEntity<Artist>, ICanGetAll<Artist>
    {
        IList<Artist> GetByAlbum(Album album);
        IList<Artist> GetByDistributor(Distributor distributor);
    }
}