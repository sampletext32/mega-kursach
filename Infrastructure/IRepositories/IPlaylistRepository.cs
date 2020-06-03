using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IPlaylistRepository : ICanAddEntity<Playlist>, ICanGetEntity<Playlist>, ICanUpdateEntity<Playlist>,
        ICanRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
        IList<Playlist> GetByOwner(User owner);
        IList<Playlist> GetByTitle(string title);
    }
}