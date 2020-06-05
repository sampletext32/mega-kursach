using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Track : TitledEntity
    {
        public ICollection<Artist> Artists { get; set; }

        public int GenreId { get; set; }

        public int ArtId { get; set; }

        public bool Explicit { get; set; }

        public int AlbumId { get; set; }
        public int NumberOfPlays { get; set; }

        public Track(int id, string title, ICollection<Artist> artists, int genreId, int artId, bool @explicit,
            int albumId, int numberOfPlays) :
            base(id, title)
        {
            Explicit = @explicit;
            Artists = artists;
            GenreId = genreId;
            ArtId = artId;
            AlbumId = albumId;
            NumberOfPlays = numberOfPlays;
        }

        public Track()
        {
        }
    }
}