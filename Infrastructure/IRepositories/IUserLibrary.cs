using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IUserLibrary : ICanAddEntity<UserLibrary>, ICanGetEntityById<UserLibrary>, ICanUpdateEntity<UserLibrary>,
        ICanRemoveEntity<UserLibrary>, ICanGetAll<UserLibrary>
    {
    }
}
