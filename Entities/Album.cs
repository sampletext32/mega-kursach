using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }

        [JsonIgnore] 
        public virtual ICollection<Artist> MainArtists { get; set; }

        [NotMapped] 
        public int Plays => Tracks.Sum(t => t.Plays);

        public int DistributorId { get; set; }

        public virtual Distributor Distributor { get; set; }

        public Album(string title, int ownerId, int artId, int distributorId,
            int year) : base(title, ownerId, artId)
        {
            DistributorId = distributorId;
            Year = year;
        }

        public Album()
        {
        }
    }
}