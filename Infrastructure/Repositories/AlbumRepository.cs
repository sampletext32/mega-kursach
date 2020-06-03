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

        public IList<Album> GetByYear(int year)
        {
            return DbContext.Albums.Where(x => x.Year.Equals(year)).ToList();
        }

        public IList<Album> GetByArtist(Artist artist)
        {
            return DbContext.Albums.Where(x => x.MainArtists.Contains(artist)).ToList();
        }

        public IList<Album> GetByTitle(string title)
        {
            return DbContext.Albums.Where(x => x.Title.Equals(title)).ToList();
        }

        public IList<Album> GetByDistributor(Distributor distributor)
        {
            return DbContext.Albums.Where(x => x.Distributor.Equals(distributor)).ToList();
        }

        public IList<Album> GetAll()
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