using System.Collections.Generic;
using System.Linq;
using Entities;
using Infrastructure.CommonRepositories;
using Infrastructure.IRepositories;

namespace Infrastructure.Repositories
{
    public class PlaylistRepository : AuditableEntityDbRepository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IList<Playlist> GetByOwner(User owner)
        {
            return DbContext.Playlists.Where(x => x.OwnerId.Equals(owner)).ToList();
        }

        public IList<Playlist> GetAll()
        {
            return DbContext.Playlists.ToList();
        }

        public IList<Playlist> GetByTitle(string title)
        {
            return DbContext.Playlists.Where(x => x.Title.Equals(title)).ToList();
        }

        public void Add(Playlist entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Playlist Get(int id)
        {
            return DbGet(id);
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
    }
}