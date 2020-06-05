using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Distributor : User
    {
        public ICollection<Album> Albums { get; set; }
        public ICollection<Artist> Artists { get; set; }

        public Distributor(int id, string nickname, string password, string email, ICollection<Album> albums,
            ICollection<Artist> artists) : base(id, nickname, password, email)
        {
            Albums = albums;
            Artists = artists;
        }

        public Distributor()
        {
        }
    }
}