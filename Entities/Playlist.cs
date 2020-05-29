﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entities
{
    public class Playlist : TitledEntity
    {
        public ICollection<int> TracksIds { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public ICollection<Track> Tracks => null;

        public int OwnerId { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public User Owner => null;

        public int ArtId { get; set; }

        //Данное поле не будет хранится в БД
        //[NotMapped]
        //public Art Art => null;

        public Playlist(int id, string title, ICollection<int> tracksIds, int ownerId, int artId) : base(id, title)
        {
            TracksIds = tracksIds;
            OwnerId = ownerId;
            ArtId = artId;
        }
    }
}