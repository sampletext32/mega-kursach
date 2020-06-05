using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entities
{
    public class Playlist : TitledEntity
    {
        public ICollection<Track> Tracks { get; set; }

        public int OwnerId { get; set; }

        public int ArtId { get; set; }

        public Playlist(int id, string title, ICollection<Track> tracks, int ownerId, int artId) : base(id, title)
        {
            Tracks = tracks;
            OwnerId = ownerId;
            ArtId = artId;
        }

        public Playlist()
        {
        }
    }
}