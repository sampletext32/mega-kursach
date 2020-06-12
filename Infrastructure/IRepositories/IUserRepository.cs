using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IUserRepository : ICanAddEntity<User>, ICanGetEntityById<User>, ICanUpdateEntity<User>,
        ICanRemoveEntity<User>, ICanGetAll<User>
    {
    }
}