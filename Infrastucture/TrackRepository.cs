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

        public IReadOnlyList<Track> GetTracksByArtist(Artist artist)
        {
            return _dbContext.Tracks.Where(x => x.Artists.Contains(artist)).ToList();
        }

        public IReadOnlyList<Track> GetTracksByGenre(Genre genre)
        {
            return _dbContext.Tracks.Where(x => x.Genre.Equals(genre)).ToList();
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

        //public IReadOnlyList<Track> GetTracksByAlbum(Album album)
        //{
        //    return _dbContext.Tracks.Where(x => x.A.Equals(album)).ToList();
        //}
    }
}