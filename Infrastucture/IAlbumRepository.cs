using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IAlbumRepository
    {
        Album Get(int id);

        void Add(Album album);
        void Update(Album album);
        void Remove(Album album);

        IReadOnlyList<Album> GetAlbumsByYear(int year);
        IReadOnlyList<Album> GetAlbumsByArtist(Artist artist);
        IReadOnlyList<Album> GetAlbumsByTitle(string title);
        IReadOnlyList<Album> GetAllAlbums();
    }
}