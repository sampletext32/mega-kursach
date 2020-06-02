using System.Collections.Generic;

namespace Infrastucture.CRUD
{
    public interface ICanGetAll<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
    }
}