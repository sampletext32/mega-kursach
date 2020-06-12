using Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArtistToDistributor>()
                .HasKey(ad => new {ad.ArtistId, ad.DistributorId});
            modelBuilder.Entity<TrackToArtist>()
                .HasKey(ta => new {ta.TrackId, ta.ArtistId});
            modelBuilder.Entity<TrackToPlaylist>()
                .HasKey(tp => new {tp.TrackId, tp.PlaylistId});
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Art> Arts { get; set; }
        public DbSet<ArtistData> ArtistDatas { get; set; }
        public DbSet<CommonUserData> CommonUserDatas { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DistributorData> DistributorDatas { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLibrary> UserLibraries { get; set; }
    }
}