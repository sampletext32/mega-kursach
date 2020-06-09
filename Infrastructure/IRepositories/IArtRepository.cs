using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtRepository : ICanAddEntity<Art>, ICanGetEntity<Art>, ICanUpdateEntity<Art>,
        ICanRemoveEntity<Art>, ICanGetAll<Art>
    {
    }
}