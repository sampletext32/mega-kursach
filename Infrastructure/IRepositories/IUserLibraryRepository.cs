using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IUserLibraryRepository : ICanAddEntity<UserLibrary>, ICanGetEntityById<UserLibrary>, ICanUpdateEntity<UserLibrary>,
        ICanRemoveEntity<UserLibrary>, ICanGetAll<UserLibrary>
    {
    }
}
