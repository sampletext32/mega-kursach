using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class ArtistDataRepository : DbRepository<ArtistData>, IArtistDataRepository
    {
        public ArtistDataRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(ArtistData entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public ArtistData GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(ArtistData entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(ArtistData entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<ArtistData> GetAll()
        {
            return DbContext.ArtistDatas.ToList();
        }
    }
}