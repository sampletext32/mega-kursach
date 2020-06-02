using System.Collections.Generic;
using Entities;
using Infrastucture.CRUD;

namespace Infrastucture
{
    public interface IPlaylistRepository : IAddEntity<Playlist>, IGetEntity<Playlist>, IUpdateEntity<Playlist>,
        IRemoveEntity<Playlist>, ICanGetAll<Playlist>
    {
        IList<Playlist> GetByOwner(User owner);
        IList<Playlist> GetByTitle(string title);
    }
}