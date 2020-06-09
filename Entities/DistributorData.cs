using System.Collections.Generic;

namespace Entities
{
    public class DistributorData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Album> ReleasedAlbums { get; set; }

        public DistributorData(string title, ICollection<Album> releasedAlbums)
        {
            ReleasedAlbums = releasedAlbums;
            Title = title;
        }

        public DistributorData(string title)
        {
            Title = title;
        }
    }
}