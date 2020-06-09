using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual Art Art { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual DistributorData Distributor { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }

        public Album(string title,
            DateTime releaseDate,
            Art art,
            Genre genre,
            DistributorData distributor,
            ICollection<Track> tracks)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Art = art;
            Genre = genre;
            Distributor = distributor;
            Tracks = tracks;
        }

        public Album()
        {
        }
    }
}