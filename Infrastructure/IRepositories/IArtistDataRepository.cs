using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtistDataRepository : ICanAddEntity<ArtistData>, ICanGetEntity<ArtistData>,
        ICanUpdateEntity<ArtistData>,
        ICanRemoveEntity<ArtistData>, ICanGetAll<ArtistData>
    {
        ICollection<ArtistData> GetByNickname(int nickname);
        ICollection<ArtistData> GetByTrack(int trackId);
    }
}