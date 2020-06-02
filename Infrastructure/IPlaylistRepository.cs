using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IPlaylistRepository : IAddEntity<Playlist>, IGetEntity<Playlist>, IUpdateEntity<Playlist>,
        IRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
        IList<Playlist> GetByOwner(User owner);
        IList<Playlist> GetByTitle(string title);
    }
}