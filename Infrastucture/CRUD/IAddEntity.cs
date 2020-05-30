namespace Infrastucture.CRUD
{
    public interface IAddEntity<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}