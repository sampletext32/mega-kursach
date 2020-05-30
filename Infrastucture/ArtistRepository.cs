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
    }
}