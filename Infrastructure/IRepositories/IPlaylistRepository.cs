using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IPlaylistRepository : ICanAddEntity<Playlist>, ICanGetEntityById<Playlist>,
        ICanUpdateEntity<Playlist>,
        ICanRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
    }
}