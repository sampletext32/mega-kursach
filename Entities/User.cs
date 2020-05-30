using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    enum UserRoles
    {
        Admin = 1,
        Distributor = 2,
        Artist = 3,
        Client = 4
    }

    public class User : TitledEntity
    {
        public User(int id, string title) : base(id, title)
        {
        }
    }
}