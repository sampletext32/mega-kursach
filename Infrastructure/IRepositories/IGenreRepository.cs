using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IGenreRepository : ICanAddEntity<Genre>, ICanGetEntity<Genre>, ICanUpdateEntity<Genre>,
        ICanRemoveEntity<Genre>, ICanGetAll<Genre>
    {
    }
}