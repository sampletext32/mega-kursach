using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class ArtRepository : AuditableEntityDbRepository<Art>, IArtRepository
    {
        public ArtRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Art entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Art Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Art entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Art entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<Art> GetAll()
        {
            return DbContext.Arts.ToList();
        }
    }
}