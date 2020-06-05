using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface ITrackRepository : ICanAddEntity<Track>, ICanGetEntity<Track>, ICanUpdateEntity<Track>, ICanRemoveEntity<Track>, ICanGetAll<Track>
    {
        ICollection<Track> GetByArtist(int artist);
        ICollection<Track> GetByGenre(int genre);
        ICollection<Track> GetByExplicit(bool @explicit);
        ICollection<Track> GetByTitle(string title);
        ICollection<Track> GetByAlbum(int album);
    }
}