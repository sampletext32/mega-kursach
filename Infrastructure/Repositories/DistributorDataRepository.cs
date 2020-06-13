using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class DistributorDataRepository: DbRepository<DistributorData>,IDistributorDataRepository

    {
        public DistributorDataRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(DistributorData entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public DistributorData GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(DistributorData entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(DistributorData entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<DistributorData> GetAll()
        {
            return DbContext.DistributorDatas.ToList();
        }
    }
}