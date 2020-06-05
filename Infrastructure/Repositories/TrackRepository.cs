using System.Collections.Generic;
using System.Data.Entity;
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

        public ICollection<Track> GetByArtist(int artist)
        {
            return DbContext.Tracks.Include(t => t.Artists).Where(x => x.Artists.Any(a => a.Id == artist)).ToList();
        }

        public ICollection<Track> GetByGenre(int genre)
        {
            return DbContext.Tracks.Where(x => x.GenreId.Equals(genre)).ToList();
        }

        public ICollection<Track> GetByExplicit(bool @explicit)
        {
            return DbContext.Tracks.Where(x => x.Explicit.Equals(@explicit)).ToList();
        }

        public ICollection<Track> GetByTitle(string title)
        {
            return DbContext.Tracks.Where(x => x.Title.Equals(title)).ToList();
        }

        public ICollection<Track> GetByAlbum(int album)
        {
            return DbContext.Tracks.Where(x => x.AlbumId.Equals(album)).ToList();
        }

        public ICollection<Track> GetAll()
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