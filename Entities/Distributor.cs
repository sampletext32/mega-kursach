using System.Collections.Generic;

namespace Entities
{
    public class Distributor : User
    {
        public ICollection<Artist> DistributionArtists { get; set; }

        public ICollection<Album> DistributionAlbums { get; set; }

        public ICollection<Track> DistributionTracks { get; set; }

        public Distributor(int id, string title, string password, string email, ICollection<Artist> distributionArtists,
            ICollection<Album> distributionAlbums, ICollection<Track> distributionTracks) : base(id, title, password,
            email)
        {
            DistributionArtists = distributionArtists;
            DistributionAlbums = distributionAlbums;
            DistributionTracks = distributionTracks;
        }

        public Distributor()
        {
        }
    }
}