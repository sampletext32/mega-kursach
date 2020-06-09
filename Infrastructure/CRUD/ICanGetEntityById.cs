namespace Infrastructure.CRUD
{
    public interface ICanGetEntityById<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
    }
}