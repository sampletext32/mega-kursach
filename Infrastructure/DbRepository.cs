namespace Infrastructure
{
    public abstract class DbRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext DbContext;

        public DbRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual TEntity DbGet(int id)
        {
            return DbContext.Find<TEntity>(id);
        }

        public virtual void DbAdd(TEntity entity)
        {
            DbContext.Add(entity);
        }

        public virtual void DbUpdate(TEntity entity)
        {
            DbContext.Update(entity);
        }

        public virtual void DbRemove(TEntity entity)
        {
            DbContext.Remove(entity);
        }

        public int DbSaveChanges()
        {
            return DbContext.SaveChanges();
        }
    }
}