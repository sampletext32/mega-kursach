using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface ITrackRepository
    {
        Track Get(int id);

        void Add(Track track);
        void Update(Track track);
        void Remove(Track track);

        IReadOnlyList<Track> GetTracksByArtist(ICollection<int> artistsId);
        IReadOnlyList<Track> GetTracksByGenre(int genreId);
        IReadOnlyList<Track> GetTracksByExplicit(bool @explicit);
        IReadOnlyList<Track> GetTracksByTitle(string title);
        IReadOnlyList<Track> GetAllTracks();
        IReadOnlyList<Track> GetTracksByAlbum(int albumId);
    }
}