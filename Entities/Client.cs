namespace Entities
{
    public class Client : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }

        public Client(int id, string title, string password, string email, string firstName, string lastName,
            string middleName, int age) : base(id, title, password, email)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Age = age;
        }

        public Client()
        {
        }
    }
}