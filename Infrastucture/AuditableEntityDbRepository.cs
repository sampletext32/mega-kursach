using System;
using Entities;

namespace Infrastucture
{
    public abstract class AuditableEntityDbRepository<TEntity> : DbRepository<TEntity>
        where TEntity : AuditableEntity
    {
        public AuditableEntityDbRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override void DbAdd(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            base.DbAdd(entity);
            DbSaveChanges();
        }

        public override void DbUpdate(TEntity entity)
        {
            entity.ModifiedAt = DateTime.Now;
            base.DbUpdate(entity);
            DbSaveChanges();
        }
    }
}