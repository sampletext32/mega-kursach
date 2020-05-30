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

        public IReadOnlyList<Album> GetAlbumsByArtist(Artist artist)
        {
            return _dbContext.Albums.Where(x => x.MainArtists.Contains(artist)).ToList();
        }

        public IReadOnlyList<Album> GetAlbumsByTitle(string title)
        {
            return _dbContext.Albums.Where(x => x.Title.Equals(title)).ToList();
        }

        public IReadOnlyList<Album> GetAllAlbums()
        {
            return _dbContext.Albums.ToList();
        }

        public IReadOnlyList<Album> GetArtists(ICollection<Artist> mainArtists)
        {
            return _dbContext.Albums.Where(x => x.MainArtists.Equals(mainArtists)).ToList();
        }
    }
}