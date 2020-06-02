using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IGenreRepository : IAddEntity<Genre>, IGetEntity<Genre>, IUpdateEntity<Genre>,
        IRemoveEntity<Genre>, ICanGetAll<Genre>
    {
    }
}