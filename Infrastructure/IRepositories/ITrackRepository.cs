using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface ITrackRepository : ICanAddEntity<Track>, ICanGetEntity<Track>, ICanUpdateEntity<Track>, ICanRemoveEntity<Track>, ICanGetAll<Track>
    {
        IList<Track> GetByArtist(Artist artist);
        IList<Track> GetByGenre(Genre genre);
        IList<Track> GetByExplicit(bool @explicit);
        IList<Track> GetByTitle(string title);
        IList<Track> GetByAlbum(Album album);
    }
}