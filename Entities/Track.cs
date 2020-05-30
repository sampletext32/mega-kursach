using System;
using System.Collections.Generic;

namespace Entities
{
    public class Track : TitledEntity
    {
        public ICollection<int> ArtistsIds { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public ICollection<Artist> Artists => null;

        public int GenreId { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public Genre Genre => null;

        public int ArtId { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public Art Art => null;


        public bool Explicit { get; set; }
        public int AlbumId { get; set; }

        public Track(int id, string title, ICollection<int> artistsIds, int genreId, int artId, bool @explicit,
            int albumId) :
            base(id, title)
        {
            Explicit = @explicit;
            ArtistsIds = artistsIds;
            GenreId = genreId;
            ArtId = artId;
            AlbumId = albumId;
        }
    }
}