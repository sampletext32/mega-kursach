using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entities
{
    public class Track : TitledEntity
    {
        [JsonIgnore] 
        public virtual ICollection<Artist> Artists { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public int ArtId { get; set; }

        public virtual Art Art { get; set; }

        public bool Explicit { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }

        public int Plays { get; set; }

        public Track(string title, int genreId, int artId, bool @explicit, int albumId, int plays) :
            base(title)
        {
            Explicit = @explicit;
            GenreId = genreId;
            ArtId = artId;
            AlbumId = albumId;
            Plays = plays;
        }

        public Track()
        {
        }
    }
}