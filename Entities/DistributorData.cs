using System.Collections.Generic;

namespace Entities
{
    public class DistributorData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Album> ReleasedAlbums { get; set; }
        public virtual ICollection<ArtistToDistributor> Artists { get; set; }
        public virtual Country Country { get; set; }

        public DistributorData(
            string title,
            ICollection<Album> releasedAlbums,
            ICollection<ArtistToDistributor> artists, Country country)
        {
            Title = title;
            ReleasedAlbums = releasedAlbums;
            Artists = artists;
            Country = country;
        }

        public DistributorData()
        {
        }
    }
}