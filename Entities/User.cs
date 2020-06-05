using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public enum UserRole : int
    {
        Admin = 1,
        Distributor = 2,
        Artist = 3,
        Client = 4
    }

    public abstract class User : AuditableEntity
    {
        public UserRole Role { get; set; }

        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(UserRole role, string nickname, string password, string email)
        {
            Role = role;
            Nickname = nickname;
            Password = password;
            Email = email;
        }

        public User()
        {
        }
    }
}