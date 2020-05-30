using System;
using Entities;

namespace Infrastucture
{
    public abstract class AuditableEntityRepository<TEntity> : Repository<TEntity>
        where TEntity : AuditableEntity
    {
        public AuditableEntityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            base.Add(entity);
            SaveChanges();
        }

        public override void Update(TEntity entity)
        {
            entity.ModifiedAt = DateTime.Now;
            base.Update(entity);
            SaveChanges();
        }
    }
}