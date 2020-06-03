namespace Infrastructure.CRUD
{
    public interface ICanGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}