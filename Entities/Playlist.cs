using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public Art Art { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<TrackToPlaylist> Tracks { get; set; }

        public Playlist(Art art, string title, string description, ICollection<TrackToPlaylist> tracks)
        {
            Art = art;
            Title = title;
            Description = description;
            Tracks = tracks;
        }

        public Playlist()
        {
        }
    }
}