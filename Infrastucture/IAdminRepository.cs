using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IAdminRepository : IAddEntity<Admin>, IGetEntity<Admin>, IUpdateEntity<Admin>,
        IRemoveEntity<Admin>, ICanGetAll<Admin>
    {
    }
}