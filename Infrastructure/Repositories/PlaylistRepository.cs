using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class PlaylistRepository : DbRepository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Playlist entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Playlist GetById(int id)
        {
            return DbGetById(id);
        }

        public void Update(Playlist entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Playlist entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }

        public ICollection<Playlist> GetAll()
        {
            return DbContext.Playlists.ToList();
        }
    }
}