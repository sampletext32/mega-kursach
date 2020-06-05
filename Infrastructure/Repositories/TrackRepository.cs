using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class TrackRepository : AuditableEntityDbRepository<Track>, ITrackRepository
    {
        public TrackRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IList<Track> GetByArtist(Artist artist)
        {
            return DbContext.Tracks.Where(x => x.Artists.Contains(artist)).ToList();
        }

        public IList<Track> GetByGenre(Genre genre)
        {
            return DbContext.Tracks.Where(x => x.GenreId.Equals(genre)).ToList();
        }

        public IList<Track> GetByExplicit(bool @explicit)
        {
            return DbContext.Tracks.Where(x => x.Explicit.Equals(@explicit)).ToList();
        }

        public IList<Track> GetByTitle(string title)
        {
            return DbContext.Tracks.Where(x => x.Title.Contains(title)).ToList();
        }

        public IList<Track> GetByAlbum(Album album)
        {
            return DbContext.Tracks.Where(x => x.AlbumId.Equals(albumId)).ToList();
        }

        public IList<Track> GetAll()
        {
            return DbContext.Tracks.ToList();
        }

        public void Add(Track entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Track Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Track entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Track entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }
    }
}