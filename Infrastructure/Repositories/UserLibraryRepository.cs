using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class UserLibraryRepository : DbRepository<UserLibrary>, IUserLibraryRepository
    {
        public UserLibraryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(UserLibrary entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public UserLibrary GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(UserLibrary entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(UserLibrary entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<UserLibrary> GetAll()
        {
            return DbContext.UserLibraries.ToList();
        }
    }
}