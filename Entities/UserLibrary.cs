using System.Collections.Generic;

namespace Entities
{
    public class UserLibrary
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }

        public UserLibrary(User user, ICollection<Album> albums, ICollection<Playlist> playlists)
        {
            User = user;
            Albums = albums;
            Playlists = playlists;
        }

        public UserLibrary()
        {
        }
    }
}