using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Infrastucture
{
    public class ArtistRepository : AuditableEntityRepository<Artist>, IArtistRepository
    {
        private readonly AppDbContext _dbContext;

        public ArtistRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Artist> GetArtists()
        {
            return _dbContext.Artists.ToList();
        }

        public IReadOnlyList<Artist> GetArtistsByAlbum(int albumId)
        {
            return _dbContext.Artists.Where(x => x.AlbumId.Equals(albumId)).ToList();
        }
    }
}