using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IAlbumRepository : ICanAddEntity<Album>, ICanGetEntityById<Album>, ICanUpdateEntity<Album>,
        ICanRemoveEntity<Album>, ICanGetAll<Album>
    {
    }
}