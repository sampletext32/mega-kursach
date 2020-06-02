namespace Infrastructure.CRUD
{
    public interface IGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}