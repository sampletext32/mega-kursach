using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IAdminRepository : ICanAddEntity<Admin>, ICanGetEntity<Admin>, ICanUpdateEntity<Admin>,
        ICanRemoveEntity<Admin>, ICanGetAll<Admin>
    {
    }
}