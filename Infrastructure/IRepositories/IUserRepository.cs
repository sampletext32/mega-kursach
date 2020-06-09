using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IUserRepository : ICanAddEntity<User>, ICanGetEntity<User>, ICanUpdateEntity<User>,
        ICanRemoveEntity<User>, ICanGetAll<User>
    {
        User GetByLoginAndPassword(string login, string password);
        ICollection<User> Search(string query);
    }
}