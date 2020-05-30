using System.Collections.Generic;
using System.Linq;
using Entities;


namespace Infrastucture
{
    public class DistributorRepository : AuditableEntityRepository<Distributor>, IDistributorRepository
    {
        private readonly AppDbContext _dbContext;

        public DistributorRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Distributor> GetDistributionAlbums(ICollection<Album> distributionAlbums)
        {
            return _dbContext.Distributors.Where(x => x.DistributionAlbums.Equals(distributionAlbums)).ToList();
        }

        public IReadOnlyList<Distributor> GetDistributionArtists(ICollection<Artist> distributionArtists)
        {
            return _dbContext.Distributors.Where(x => x.DistributionArtists.Equals(distributionArtists)).ToList();
        }

        public IReadOnlyList<Distributor> GetDistributionTracks(ICollection<Track> distributionTracks)
        {
            return _dbContext.Distributors.Where(x => x.DistributionTracks.Equals(distributionTracks)).ToList();
        }
    }
}