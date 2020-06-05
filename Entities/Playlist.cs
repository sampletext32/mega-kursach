using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace Entities
{
    public class Playlist : TitledEntity
    {
        [JsonIgnore]
        public virtual ICollection<Track> Tracks { get; set; }

        public int OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public int ArtId { get; set; }

        public virtual Art Art { get; set; }

        public Playlist(string title, int ownerId, int artId) : base(title)
        {
            OwnerId = ownerId;
            ArtId = artId;
        }

        public Playlist()
        {
        }
    }
}