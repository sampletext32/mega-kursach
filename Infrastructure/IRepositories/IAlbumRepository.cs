using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IAlbumRepository : ICanAddEntity<Album>, ICanGetEntity<Album>, ICanUpdateEntity<Album>,
        ICanRemoveEntity<Album>, ICanGetAll<Album>
    {
        ICollection<Album> GetByReleaseDate(int releaseDate);
        ICollection<Album> GetByTitle(int title);
        ICollection<Album> GetByGenre(int genre);
    }
}