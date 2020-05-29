using System.Collections.Generic;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }
        public ICollection<string> Artists { get; set; }

        public Album(int id, string title, ICollection<int> tracksIds, int ownerId, int artId, int year, ICollection<string> artists) : base(id, title, tracksIds, ownerId, artId)
        {
            Year = year;
            Artists = artists;
        }
    }
}