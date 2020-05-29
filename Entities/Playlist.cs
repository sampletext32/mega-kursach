using System.Collections.Generic;

namespace Entities
{
    public class Playlist : Entity
    {
        public List<int> TracksIds { get; set; }
        public int OwnerId { get; set; }
        public int ArtId { get; set; }


        public Playlist(int id, string title, List<int> tracksIds, int ownerId, int artId)
        {
            Id = id;
            Title = Title;
            TracksIds = tracksIds;
            OwnerId = ownerId;
            ArtId = artId;
        }
    }
}