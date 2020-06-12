using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IGenreRepository : ICanAddEntity<Genre>, ICanGetEntityById<Genre>, ICanUpdateEntity<Genre>,
        ICanRemoveEntity<Genre>, ICanGetAll<Genre>
    {
        
    }
}