using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Artist : Client
    {
        public string Bio { get; set; }
        public ICollection<Album> ArtistAlbums { get; set; }
        public ICollection<Track> ArtistTracks { get; set; }

        public Artist(int id, string title, string password, string email, string firstName, string lastName,
            string middleName, int age, string bio, ICollection<Album> artistAlbums, ICollection<Track> artistTracks) :
            base(id, title, password, email, firstName, lastName, middleName, age)
        {
            Bio = bio;
            ArtistAlbums = artistAlbums;
            ArtistTracks = artistTracks;
        }
    }
}