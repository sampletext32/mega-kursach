using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Art Art { get; set; }
        public virtual User Owner { get; set; }
        public virtual ICollection<TrackToPlaylist> Tracks { get; set; }

        public Playlist(string title, string description, Art art, User owner, ICollection<TrackToPlaylist> tracks)
        {
            Title = title;
            Description = description;
            Art = art;
            Owner = owner;
            Tracks = tracks;
        }

        public Playlist()
        {
        }
    }
}