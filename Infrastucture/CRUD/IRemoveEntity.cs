namespace Infrastucture.CRUD
{
    public interface IRemoveEntity<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}