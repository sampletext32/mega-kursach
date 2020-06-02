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

        public Distributor Distributor { get; set; }

        public Album(int id, string title, ICollection<Track> tracks, User owner, Art art, Distributor distributor,
            int year, ICollection<Artist> mainArtists) : base(id, title, tracks, owner, art)
        {
            Distributor = distributor;
            Year = year;
            MainArtists = mainArtists;
        }

        public Album()
        {
        }
    }
}