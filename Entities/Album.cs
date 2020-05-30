using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }

        public ICollection<Artist> MainArtists { get; set; }

        public Album(int id, string title, ICollection<Track> tracks, User owner, Art art, int year,
            ICollection<Artist> mainArtists) : base(id, title, tracks, owner, art)
        {
            Year = year;
            MainArtists = mainArtists;
        }
    }
}