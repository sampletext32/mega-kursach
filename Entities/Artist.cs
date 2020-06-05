using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Artist : Client
    {
        public string Bio { get; set; }
        public virtual ICollection<Album> Albums { get; set; }

        public Artist(string title, string password, string email, string firstName, string lastName,
            string middleName, DateTime birthdate, string bio) :
            base(title, password, email, firstName, lastName, middleName, birthdate)
        {
            Role = UserRole.Artist; // Hardcode 
            Bio = bio;
        }

        public Artist()
        {
        }
    }
}