using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class GenreRepository : DbRepository<Genre>, IGenreRepository
    {
        public GenreRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Genre entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Genre GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(Genre entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Genre entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<Genre> GetAll()
        {
            return DbContext.Genres.ToList();
        }
    }
}