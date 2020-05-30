using Entities;

namespace Infrastucture
{
    public interface IClientRepository
    {
        Client Get(int id);

        void Add(Client client);
        void Update(Client client);
        void Remove(Client client);
    }
}