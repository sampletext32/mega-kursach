namespace Infrastucture.CRUD
{
    public interface IGetEntity<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}