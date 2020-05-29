using System.Collections.Generic;

namespace Entities
{
    public class AudioFile : TitledEntity
    {
        public ICollection<int> ArtistsIds { get; set; }
        public int GenreId { get; set; }
        public int ArtId { get; set; }

        public AudioFile(int id, string title, ICollection<int> artistsIds, int genreId, int artId) : base(id, title)
        {
            ArtistsIds = artistsIds;
            GenreId = genreId;
            ArtId = artId;
        }
    }
}