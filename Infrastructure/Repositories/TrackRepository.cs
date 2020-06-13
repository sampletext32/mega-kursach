using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class TrackRepository : DbRepository<Track>, ITrackRepository
    {
        public TrackRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Track entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Track GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(Track entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Track entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<Track> GetAll()
        {
            return DbContext.Tracks.ToList();
        }
    }
}