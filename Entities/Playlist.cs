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
        public virtual UserLibrary OwnerLibrary { get; set; }
        public virtual ICollection<TrackToPlaylist> Tracks { get; set; }

        public Playlist(
            string title,
            string description,
            Art art,
            
            UserLibrary ownerLibrary,
            ICollection<TrackToPlaylist> tracks)
        {
            Title = title;
            Description = description;
            Art = art;
            OwnerLibrary = ownerLibrary;
            Tracks = tracks;
        }

        public Playlist()
        {
        }
    }
}