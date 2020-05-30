using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Track : TitledEntity
    {
        public ICollection<Artist> Artists { get; set; }

        public Genre Genre { get; set; }

        public Art Art { get; set; }

        public bool Explicit { get; set; }

        //public int AlbumId { get; set; }

        public Track(int id, string title, ICollection<Artist> artists, Genre genre, Art art, bool @explicit, 
            /*Album album*/) :
            base(id, title)
        {
            Explicit = @explicit;
            Artists = artists;
            Genre = genre;
            Art = art;
            //Album = album;
        }

        public Track()
        {
            
        }
    }
}