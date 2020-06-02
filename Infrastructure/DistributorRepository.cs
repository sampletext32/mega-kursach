using System.Collections.Generic;
using System.Linq;
using Entities;


namespace Infrastructure
{
    public class DistributorRepository : AuditableEntityDbRepository<Distributor>, IDistributorRepository
    {
        public DistributorRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IList<Distributor> GetAll()
        {
            return DbContext.Distributors.ToList();
        }

        public void Add(Distributor entity)
        {
            DbContext.Distributors.Add(entity);
            DbSaveChanges();
        }

        public Distributor Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Distributor entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Distributor entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }
    }
}