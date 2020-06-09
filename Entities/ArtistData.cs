using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ArtistData
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<TrackToArtist> Tracks { get; set; }
        public virtual ICollection<ArtistToDistributor> Distributors { get; set; }

        public ArtistData(
            string nickname,
            string bio,
            ICollection<TrackToArtist> tracks,
            ICollection<ArtistToDistributor> distributors)
        {
            Nickname = nickname;
            Bio = bio;
            Tracks = tracks;
            Distributors = distributors;
        }

        public ArtistData()
        {
        }
    }
}