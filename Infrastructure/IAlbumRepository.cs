using System.Collections.Generic;
using Entities;
using Infrastructure.CRUD;

namespace Infrastructure
{
    public interface IAlbumRepository : IAddEntity<Album>, IGetEntity<Album>, IUpdateEntity<Album>,
        IRemoveEntity<Album>, ICanGetAll<Album>
    {
        IList<Album> GetByYear(int year);
        IList<Album> GetByArtist(Artist artist);
        IList<Album> GetByTitle(string title);
        IList<Album> GetByDistributor(Distributor distributor);
    }
}