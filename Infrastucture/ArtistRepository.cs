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

        public IReadOnlyList<Artist> GetArtistAlbums(ICollection<Album> artistAlbums)
        {
            return _dbContext.Artists.Where(x => x.ArtistAlbums.Equals(artistAlbums)).ToList();
        }

        public IReadOnlyList<Artist> GetArtistTracks(ICollection<Track> artistTracks)
        {
            return _dbContext.Artists.Where(x => x.ArtistTracks.Equals(artistTracks)).ToList();
        }
    }
}