using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Infrastucture
{
    public class TrackRepository : AuditableEntityRepository<Track>, ITrackRepository
    {
        private readonly AppDbContext _dbContext;

        public TrackRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Track> GetTracksByArtist(ICollection<int> artistsId)
        {
            return _dbContext.Tracks.Where(x => x.ArtistsIds.Equals(artistsId)).ToList();
        }

        public IReadOnlyList<Track> GetTracksByGenre(int genreId)
        {
            return _dbContext.Tracks.Where(x => x.GenreId.Equals(genreId)).ToList();
        }

        public IReadOnlyList<Track> GetTracksByExplicit(bool @explicit)
        {
            return _dbContext.Tracks.Where(x => x.Explicit.Equals(@explicit)).ToList();
        }

        public IReadOnlyList<Track> GetTracksByTitle(string title)
        {
            return _dbContext.Tracks.Where(x => x.Title.Contains(title)).ToList();
        }

        public IReadOnlyList<Track> GetAllTracks()
        {
            return _dbContext.Tracks.ToList();
        }

        public IReadOnlyList<Track> GetTracksByAlbum(int albumId)
        {
            return _dbContext.Tracks.Where(x => x.AlbumId.Equals(albumId)).ToList();
        }
    }
}