using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IGenreRepository : IAddEntity<Genre>, IGetEntity<Genre>, IUpdateEntity<Genre>,
        IRemoveEntity<Genre>, ICanGetAll<Genre>
    {
    }
}