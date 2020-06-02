using System.Collections.Generic;

namespace Infrastructure.CRUD
{
    public interface ICanGetAll<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
    }
}