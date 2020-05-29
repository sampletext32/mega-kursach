using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }
        public ICollection<int> ArtistsId { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public ICollection<Artist> Artists => null;

        public Album(int id, string title, ICollection<int> tracksIds, int ownerId, int artId, int year, ICollection<int> artistsId) : base(id, title, tracksIds, ownerId, artId)
        {
            Year = year;
            ArtistsId = artistsId;
        }
    }
}