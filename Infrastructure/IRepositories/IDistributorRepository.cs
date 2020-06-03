using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IDistributorRepository : ICanAddEntity<Distributor>, ICanGetEntity<Distributor>,
        ICanUpdateEntity<Distributor>, ICanRemoveEntity<Distributor>, ICanGetAll<Distributor>
    {
    }
}