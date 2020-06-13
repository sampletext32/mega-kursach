using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : DbRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(User entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public User GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(User entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(User entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<User> GetAll()
        {
            return DbContext.Users.ToList();
        }
    }
}