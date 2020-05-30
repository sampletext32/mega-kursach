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

        public IReadOnlyList<Artist> GetAllArtists()
        {
            return _dbContext.Artists.ToList();
        }

        public IReadOnlyList<Artist> GetArtistsByAlbum(Album album)
        {
            return _dbContext.Artists.Where(x => album.MainArtists.Contains(x)).ToList();
        }

        public IReadOnlyList<Artist> GetArtistsByDistributor(Distributor distributor)
        {
            return _dbContext.Artists.Where(a =>
                    new AlbumRepository(_dbContext).GetAlbumsByDistributor(distributor)
                        .Any(t => t.MainArtists.Contains(a)))
                .ToList();
        }
    }
}