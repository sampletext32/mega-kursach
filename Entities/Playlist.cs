using System.Collections.Generic;

namespace Entities
{
    public class Playlist : TitledEntity
    {
        public ICollection<int> TracksIds { get; set; }
        public int OwnerId { get; set; }
        public int ArtId { get; set; }


        public Playlist(int id, string title, ICollection<int> tracksIds, int ownerId, int artId) : base(id, title)
        {
            TracksIds = tracksIds;
            OwnerId = ownerId;
            ArtId = artId;
        }
    }
}