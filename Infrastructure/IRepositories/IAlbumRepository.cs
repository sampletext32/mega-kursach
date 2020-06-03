using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IAlbumRepository : ICanAddEntity<Album>, ICanGetEntity<Album>, ICanUpdateEntity<Album>,
        ICanRemoveEntity<Album>, ICanGetAll<Album>
    {
        IList<Album> GetByYear(int year);
        IList<Album> GetByArtist(Artist artist);
        IList<Album> GetByTitle(string title);
        IList<Album> GetByDistributor(Distributor distributor);
    }
}