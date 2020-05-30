using Entities;

namespace Infrastucture
{
    public interface IAdminRepository
    {
        Admin Get(int id);

        void Add(Admin admin);
        void Update(Admin admin);
        void Remove(Admin admin);
    }
}