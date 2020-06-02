using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IDistributorRepository : IAddEntity<Distributor>, IGetEntity<Distributor>,
        IUpdateEntity<Distributor>, IRemoveEntity<Distributor>, ICanGetAll<Distributor>
    {
    }
}