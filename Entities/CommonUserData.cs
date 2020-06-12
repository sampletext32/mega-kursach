using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CommonUserData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }

        public CommonUserData(
            string firstName,
            string lastName,
            string middleName,
            DateTime? birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            BirthDate = birthDate;
        }

        public CommonUserData()
        {
        }
    }
}