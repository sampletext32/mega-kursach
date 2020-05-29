using System.Collections.Generic;

namespace Entities
{
    public class AudioFile : Entity
    {
        public List<string> Artists { get; set; }
        public int GenreId { get; set; }
        public int ArtId { get; set; }

        public AudioFile(int id, string title, List<string> artists, int genreId, int artId) : base(id, title)
        {
            Id = id;
            Title = title;
            Artists = artists;
            GenreId = genreId;
            ArtId = artId;
        }
    }
}