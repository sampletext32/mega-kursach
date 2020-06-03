namespace Infrastructure.CRUD
{
    public interface ICanUpdateEntity<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}