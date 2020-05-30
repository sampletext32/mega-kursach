using System;

namespace Entities
{
    public class Client : User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime Birthdate { get; set; }

        public Client(int id, string title, string password, string email, string firstName, string lastName,
            string middleName, DateTime birthdate) : base(id, title, password, email)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Birthdate = birthdate;
        }

        public Client()
        {
        }
    }
}