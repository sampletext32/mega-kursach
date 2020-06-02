using System.Collections.Generic;
using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IDistributorRepository : IAddEntity<Distributor>, IGetEntity<Distributor>,
        IUpdateEntity<Distributor>, IRemoveEntity<Distributor>, ICanGetAll<Distributor>
    {
    }
}