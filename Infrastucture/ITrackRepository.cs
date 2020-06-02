using System.Collections.Generic;
using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface ITrackRepository : IAddEntity<Track>, IGetEntity<Track>, IUpdateEntity<Track>, IRemoveEntity<Track>, ICanGetAll<Track>
    {
        IList<Track> GetByArtist(Artist artist);
        IList<Track> GetByGenre(Genre genre);
        IList<Track> GetByExplicit(bool @explicit);
        IList<Track> GetByTitle(string title);
        IList<Track> GetByAlbum(Album album);
    }
}