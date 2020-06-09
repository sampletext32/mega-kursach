using System.Collections.Generic;

namespace Entities
{
    public class UserLibrary
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Album> AddedAlbums { get; set; }
        public virtual ICollection<Playlist> AddedPlaylists { get; set; }

        public UserLibrary(User user, ICollection<Album> addedAlbums, ICollection<Playlist> addedPlaylists)
        {
            User = user;
            AddedAlbums = addedAlbums;
            AddedPlaylists = addedPlaylists;
        }

        public UserLibrary()
        {
        }
    }
}