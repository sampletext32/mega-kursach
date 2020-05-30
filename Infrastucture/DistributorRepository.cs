using System.Collections.Generic;
using System.Linq;
using Entities;


namespace Infrastucture
{
    public class DistributorRepository : AuditableEntityRepository<Distributor>, IDistributorRepository
    {
        private readonly AppDbContext _dbContext;

        public DistributorRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}