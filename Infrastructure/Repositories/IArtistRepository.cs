using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.Repositories
{
    public interface IArtistRepository : ICanAddEntity<ArtistData>, ICanGetEntity<ArtistData>,
        ICanUpdateEntity<ArtistData>,
        ICanRemoveEntity<ArtistData>, ICanGetAll<ArtistData>
    {
        ICollection<ArtistData> GetByNickname(int nickname);
        ICollection<ArtistData> GetByTrack(int trackId);
    }
}