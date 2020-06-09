using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.Repositories
{
    public interface IPlaylistRepository : ICanAddEntity<Playlist>, ICanGetEntity<Playlist>, ICanUpdateEntity<Playlist>,
        ICanRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
        ICollection<Playlist> GetByTitle(int title);
        ICollection<Playlist> GetByOwner(int ownerId);
    }
}