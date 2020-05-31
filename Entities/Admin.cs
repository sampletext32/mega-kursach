namespace Entities
{
    public class Admin : User
    {
        public Admin(int id, string nickname, string password, string email) : base(id, nickname, password, email)
        {
        }

        public Admin()
        {
        }
    }
}