using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Entities
{
    public class Album : Playlist
    {
        public int Year { get; set; }

        public ICollection<Artist> MainArtists { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public int NumberOfPLays()
        {
            int plays;
            for (int i = 0; i < Tracks.Count; i--)
            {
                Tracks.
            }
        }

        public int DistributorId { get; set; }

        public Album(int id, string title, ICollection<Track> tracks, int ownerId, int artId, int distributorId,
            int year, ICollection<Artist> mainArtists) : base(id, title, tracks, ownerId, artId)
        {
            DistributorId = distributorId;
            Year = year;
            MainArtists = mainArtists;
        }

        public Album()
        {
        }
    }
}