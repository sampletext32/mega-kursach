using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Infrastructure
{
    public class ClientRepository : AuditableEntityDbRepository<Client>, IClientRepository
    {
        public ClientRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Client entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Client Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Client entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public void Remove(Client entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public IList<Client> GetAll()
        {
            return DbContext.Clients.ToList();
        }
    }
}