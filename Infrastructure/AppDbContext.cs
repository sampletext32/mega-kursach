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

        public DbSet<Album> Albums { get; set; }
        public DbSet<Art> Arts { get; set; }
        public DbSet<ArtistData> ArtistDatas { get; set; }
        public DbSet<ArtistToDistributor> ArtistToDistributors { get; set; }
        public DbSet<CommonUserData> CommonUserDatas { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DistributorData> DistributorDatas { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<TrackToArtist> TracksToArtists { get; set; }
        public DbSet<TrackToPlaylist> TracksToPlaylists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}