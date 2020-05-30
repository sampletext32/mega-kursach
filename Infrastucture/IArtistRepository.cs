using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IArtistRepository
    {
        Artist Get(int id);

        void Add(Artist artist);
        void Update(Artist artist);

        IReadOnlyList<Artist> GetArtists();
        IReadOnlyList<Artist> GetArtistsByAlbum(ICollection<int> albumId);
    }
}