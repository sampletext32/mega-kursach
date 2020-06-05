using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Distributor : User
    {
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }

        public Distributor(string nickname, string password, string email) : base(UserRole.Distributor, nickname, password, email)
        {
        }

        public Distributor()
        {
        }
    }
}