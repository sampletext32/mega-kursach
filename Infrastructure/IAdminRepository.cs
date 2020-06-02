using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IAdminRepository : IAddEntity<Admin>, IGetEntity<Admin>, IUpdateEntity<Admin>,
        IRemoveEntity<Admin>, ICanGetAll<Admin>
    {
    }
}