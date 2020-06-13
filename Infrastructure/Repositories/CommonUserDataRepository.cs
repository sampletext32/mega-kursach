using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class CommonUserDataRepository : DbRepository<CommonUserData>, ICommonUserDataRepository

    {
        public CommonUserDataRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(CommonUserData entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public CommonUserData GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(CommonUserData entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(CommonUserData entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<CommonUserData> GetAll()
        {
            return DbContext.CommonUserDatas.ToList();
        }
    }
}