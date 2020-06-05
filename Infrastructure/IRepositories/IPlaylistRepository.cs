using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IPlaylistRepository : ICanAddEntity<Playlist>, ICanGetEntity<Playlist>, ICanUpdateEntity<Playlist>,
        ICanRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
        ICollection<Playlist> GetByOwner(int owner);
        ICollection<Playlist> GetByTitle(string title);
    }
}