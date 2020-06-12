using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IDistributorDataRepository: ICanAddEntity<DistributorData>, ICanGetEntityById<DistributorData>, ICanUpdateEntity<DistributorData>,
        ICanRemoveEntity<DistributorData>, ICanGetAll<DistributorData>
    {
        
    }
}