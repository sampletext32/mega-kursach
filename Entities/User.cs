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
        //Title is a Nickname

        public string Password { get; set; }
        public string Email { get; set; }

        public User(int id, string title, string password, string email) : base(id, title)
        {
            Password = password;
            Email = email;
        }

        public User()
        {
        }
    }
}