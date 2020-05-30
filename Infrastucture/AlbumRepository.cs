using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Infrastucture
{
    public class AlbumRepository : AuditableEntityRepository<Album>, IAlbumRepository
    {
        private readonly AppDbContext _dbContext;

        public AlbumRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public IReadOnlyList<Album> GetAlbumsByYear(int year)
        {
            return _dbContext.Albums.Where(x => x.Year.Equals(year)).ToList();
        }

        public IReadOnlyList<Album> GetAlbumsByArtist(int artistId)
        {
            return _dbContext.Albums.Where(x => x.ArtistsId.Equals(artistId)).ToList();
        }

        public IReadOnlyList<Album> GetAlbumsByTitle(string title)
        {
            return _dbContext.Albums.Where(x => x.Title.Contains(title)).ToList();
        }

        public IReadOnlyList<Album> GetAllAlbums()
        {
            return _dbContext.Albums.ToList();
        }
    }
}