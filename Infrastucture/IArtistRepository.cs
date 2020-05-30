using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IArtistRepository
    {
        Artist Get(int id);

        void Add(Artist artist);
        void Update(Artist artist);
        void Remove(Artist artist);

        IReadOnlyList<Artist> GetArtists();
        IReadOnlyList<Artist> GetArtistsByAlbum(int albumId);
    }
}