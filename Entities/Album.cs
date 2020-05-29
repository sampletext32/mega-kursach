using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }
        public ICollection<int> ArtistsId { get; set; }

        public Album(int id, string title, ICollection<int> tracksIds, int ownerId, int artId, int year, ICollection<int> artistsId) : base(id, title, tracksIds, ownerId, artId)
        {
            Year = year;
            ArtistsId = artistsId;
        }
    }
}