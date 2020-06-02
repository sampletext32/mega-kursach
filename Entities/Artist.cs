using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Artist : Client
    {
        public string Bio { get; set; }

        public Artist(int id, string title, string password, string email, string firstName, string lastName,
            string middleName, DateTime birthdate, string bio) :
            base(id, title, password, email, firstName, lastName, middleName, birthdate)
        {
            Bio = bio;
        }

        public Artist()
        {
        }
    }
}