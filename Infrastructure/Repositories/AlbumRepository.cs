using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class AlbumRepository : DbRepository<AlbumRepository>, IAlbumRepository
    {
        public AlbumRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Album entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Album GetById(int id)
        {
            return DbGetById(id);
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

        public ICollection<Album> GetAll()
        {
            return DbContext.Albums.ToList();
        }
    }
}