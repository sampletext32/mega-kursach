using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IClientRepository : IAddEntity<Client>, IGetEntity<Client>, IUpdateEntity<Client>,
        IRemoveEntity<Client>, ICanGetAll<Client>
    {
    }
}