using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IAlbumRepository : ICanAddEntity<Album>, ICanGetEntity<Album>, ICanUpdateEntity<Album>,
        ICanRemoveEntity<Album>, ICanGetAll<Album>
    {
        ICollection<Album> GetByYear(int year);
        ICollection<Album> GetByArtist(int artist);
        ICollection<Album> GetByTitle(string title);
        ICollection<Album> GetByDistributor(int distributor);
    }
}