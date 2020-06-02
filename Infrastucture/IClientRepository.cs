using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IClientRepository : IAddEntity<Client>, IGetEntity<Client>, IUpdateEntity<Client>,
        IRemoveEntity<Client>, ICanGetAll<Client>
    {
    }
}