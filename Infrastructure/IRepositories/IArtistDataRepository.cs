using Entities;
using Infrastructure.CRUD;

namespace Infrastructure.IRepositories
{
    public interface IArtistDataRepository : ICanAddEntity<ArtistData>, ICanGetEntityById<ArtistData>,
        ICanUpdateEntity<ArtistData>,
        ICanRemoveEntity<ArtistData>, ICanGetAll<ArtistData>
    {
    }
}