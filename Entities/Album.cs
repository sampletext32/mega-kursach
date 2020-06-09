using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Album
    {
        public int Id { get; set; }
        public Art Art { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DistributorData Distributor { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public Album(Art art, DateTime releaseDate, string title, Genre genre, DistributorData distributor,
            ICollection<Track> tracks)
        {
            Art = art;
            ReleaseDate = releaseDate;
            Title = title;
            Genre = genre;
            Distributor = distributor;
            Tracks = tracks;
        }

        public Album()
        {
        }
    }
}