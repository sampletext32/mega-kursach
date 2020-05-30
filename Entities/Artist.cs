using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Artist : TitledEntity
    {
        public ICollection<int> AlbumId { get; set; }

        public Artist(int id, string title, ICollection<int> albumId) : base(id, title)
        {
            AlbumId = albumId;
        }
    }
}