namespace Entities
{
    public class Admin : User
    {
        public Admin(int id, string title, string password, string email) : base(id, title, password, email)
        {
        }

        public Admin()
        {
        }
    }
}