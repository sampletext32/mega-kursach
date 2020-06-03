using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IClientRepository : ICanAddEntity<Client>, ICanGetEntity<Client>, ICanUpdateEntity<Client>,
        ICanRemoveEntity<Client>, ICanGetAll<Client>
    {
    }
}