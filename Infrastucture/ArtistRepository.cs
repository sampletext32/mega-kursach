using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Infrastucture
{
    public class ArtistRepository : AuditableEntityDbRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IList<Artist> GetAll()
        {
            return DbContext.Artists.ToList();
        }

        public IList<Artist> GetByAlbum(Album album)
        {
            return DbContext.Artists.Where(x => album.MainArtists.Contains(x)).ToList();
        }

        public IList<Artist> GetByDistributor(Distributor distributor)
        {
            return DbContext.Artists.Where(a =>
                    new AlbumRepository(DbContext).GetByDistributor(distributor)
                        .Any(t => t.MainArtists.Contains(a)))
                .ToList();
        }

        public void Add(Artist entity)
        {
            DbAdd(entity);
            DbSaveChanges();
        }

        public Artist Get(int id)
        {
            return DbGet(id);
        }

        public void Update(Artist entity)
        {
            DbUpdate(entity);
            DbSaveChanges();
        }

        public void Remove(Artist entity)
        {
            DbRemove(entity);
            DbSaveChanges();
        }
    }
}