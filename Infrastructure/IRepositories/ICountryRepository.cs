using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface ICountryRepository : ICanAddEntity<Country>, ICanGetEntityById<Country>, ICanUpdateEntity<Country>,
        ICanRemoveEntity<Country>, ICanGetAll<Country>
    {
    }
}