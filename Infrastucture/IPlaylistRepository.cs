using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IPlaylistRepository
    {
        Playlist Get(int id);

        void Add(Playlist playlist);

        void Update(Playlist playlist);

        void Remove(Playlist playlist);

        IReadOnlyList<Playlist> GetPlaylistByOwner(User owner);

        IReadOnlyList<Playlist> GetPlaylists();

        IReadOnlyList<Playlist> GetPlaylistsByTitle(string title);
    }
}