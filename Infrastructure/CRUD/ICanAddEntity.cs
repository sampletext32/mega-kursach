namespace Infrastructure.CRUD
{
    public interface ICanAddEntity<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}