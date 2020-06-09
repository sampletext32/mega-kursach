using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.Repositories
{
    public interface ITrackRepository : ICanAddEntity<Track>, ICanGetEntity<Track>, ICanUpdateEntity<Track>,
        ICanRemoveEntity<Track>, ICanGetAll<Track>
    {
        ICollection<Track> GetByTitle(int title);
        ICollection<Track> GetWhereNotExplicit(bool isExplicit);
        ICollection<Track> GetByAlbum(int albumId);
    }
}