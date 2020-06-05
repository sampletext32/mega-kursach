using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class ArtistRepository : AuditableEntityDbRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Artist> GetAll()
        {
            return DbContext.Artists.ToList();
        }

        public ICollection<Artist> GetByAlbum(int album)
        {
            return DbContext.Albums.Find(album)?.Artists.ToList();
        }

        public void Add(Artist entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Artist Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Artist entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Artist entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }
    }
}