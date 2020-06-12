using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface ITrackRepository : ICanAddEntity<Track>, ICanGetEntityById<Track>, ICanUpdateEntity<Track>,
        ICanRemoveEntity<Track>, ICanGetAll<Track>
    {
    }
}