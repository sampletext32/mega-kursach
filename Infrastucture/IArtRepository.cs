using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IArtRepository : IAddEntity<Art>, IGetEntity<Art>, IUpdateEntity<Art>, IRemoveEntity<Art>,
        ICanGetAll<Art>
    {
    }
}