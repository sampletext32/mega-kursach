using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IArtRepository : IAddEntity<Art>, IGetEntity<Art>, IUpdateEntity<Art>, IRemoveEntity<Art>,
        ICanGetAll<Art>
    {
    }
}