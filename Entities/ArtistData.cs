using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ArtistData
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Bio { get; set; }

        public ArtistData(string nickname, string bio)
        {
            Nickname = nickname;
            Bio = bio;
        }

        public ArtistData()
        {
        }
    }
}