using System.Collections.Generic;

namespace Entities
{
    public class Distributor : User
    {
        public Distributor(int id, string nickname, string password, string email) : base(id, nickname, password,
            email)
        {
        }

        public Distributor()
        {
        }
    }
}