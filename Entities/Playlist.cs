using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entities
{
    public class Playlist : TitledEntity
    {
        public ICollection<Track> Tracks { get; set; }

        public User Owner { get; set; }

        public Art Art { get; set; }

        public Playlist(int id, string title, ICollection<Track> tracks, User owner, Art art) : base(id, title)
        {
            Tracks = tracks;
            Owner = owner;
            Art = art;
        }

        public Playlist()
        {
        }
    }
}