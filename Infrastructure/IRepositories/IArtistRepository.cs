using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtistRepository : ICanAddEntity<Artist>, ICanGetEntity<Artist>, ICanUpdateEntity<Artist>,
        ICanRemoveEntity<Artist>, ICanGetAll<Artist>
    {
        ICollection<Artist> GetByAlbum(int album);
    }
}