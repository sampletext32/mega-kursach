using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtRepository : ICanAddEntity<Art>, ICanGetEntityById<Art>, ICanUpdateEntity<Art>,
        ICanRemoveEntity<Art>, ICanGetAll<Art>
    {
    }
}