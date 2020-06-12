using System.Collections.Generic;

namespace Entities
{
    public class UserLibrary
    {
        public int Id { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }

        public UserLibrary(ICollection<Album> albums, ICollection<Playlist> playlists)
        {
            Albums = albums;
            Playlists = playlists;
        }

        public UserLibrary()
        {
        }
    }
}