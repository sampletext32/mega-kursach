using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public enum Role
    {
        admin = 1,
        distributor = 2,
        artist = 3,
        user = 4
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