using Entities;

namespace Infrastucture
{
    public interface IPlaylistRepository
    {
        Playlist Get(int id);

        void Add(Playlist playlist);
        void Update(Playlist playlist);
        void Delete(Playlist playlist);
        
    }
}