using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class AlbumRepository : AuditableEntityDbRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Album> GetByYear(int year)
        {
            return DbContext.Albums.Where(x => x.Year.Equals(year)).ToList();
        }

        public ICollection<Album> GetByArtist(int artist)
        {
            return DbContext.Albums.Where(a => a.Artists.Any(albumArtist=> albumArtist.Id == artist)).ToList();
        }

        public ICollection<Album> GetByTitle(string title)
        {
            return DbContext.Albums.Where(x => x.Title.Equals(title)).ToList();
        }

        public ICollection<Album> GetByDistributor(int distributor)
        {
            return DbContext.Albums.Where(x => x.DistributorId.Equals(distributor)).ToList();
        }

        public ICollection<Album> GetAll()
        {
            return DbContext.Albums.ToList();
        }

        public void Add(Album entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Album Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Album entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Album entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }
    }
}