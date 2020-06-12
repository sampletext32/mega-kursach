using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface ICommonUserDataRepository : ICanAddEntity<CommonUserData>, ICanGetEntityById<CommonUserData>, ICanUpdateEntity<CommonUserData>,
        ICanRemoveEntity<CommonUserData>, ICanGetAll<CommonUserData>
    {
    }
}
