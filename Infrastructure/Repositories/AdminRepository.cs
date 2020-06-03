using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class AdminRepository : AuditableEntityDbRepository<Admin>, IAdminRepository
    {
        public AdminRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Admin entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Admin Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Admin entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Admin entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public IList<Admin> GetAll()
        {
            return DbContext.Admins.ToList();
        }
    }
}