namespace Entities
{
    public class Admin : User
    {
        public Admin(string nickname, string password, string email) : base(UserRole.Admin, nickname, password, email)
        {
        }

        public Admin()
        {
        }
    }
}