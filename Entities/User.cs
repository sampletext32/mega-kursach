using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public enum UserRole : int
    {
        Admin = 1,
        Distributor = 2,
        Artist = 3,
        User = 4
    }

    public class User : TitledEntity
    {
        //Title is a Nickname

        public string Password { get; set; }
        public string Email { get; set; }

        public User(int id, string nickname, string password, string email) : base(id, nickname)
        {
            Password = password;
            Email = email;
        }

        public User()
        {
        }
    }
}