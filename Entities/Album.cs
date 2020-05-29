using System.Collections.Generic;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }
        public List<string> Artists { get; set; }
        public int ArtId { get; set; }

        public Album(int id, string title, List<int> tracksIds, int ownerId, int artId, int year, List<string> artists) : base(id, title, tracksIds, ownerId, artId)
        {
            Id = id;
            Title = title;
            Year = year;
            Artists = artists;
            ArtId = artId;
        }
    }
}