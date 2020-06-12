using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class CountryRepository : DbRepository<Country>, ICountryRepository
    {
        public CountryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Country entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Country GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(Country entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Country entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<Country> GetAll()
        {
            return DbContext.Countries.ToList();
        }
    }
}