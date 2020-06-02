using Infrastucture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using Entities;
using Infrustucture;

namespace ConsoleTester
{
    //Фабрика для создания объекта контекста базы данных во время разработки
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WOdio;Trusted_Connection=True;",
                b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }


    class Program
    {
        private static readonly AppDbContext _appContext;
        private static IAdminRepository _adminRepository;
        private static IAlbumRepository _albumRepository;
        private static IArtistRepository _artistRepository;
        private static IArtRepository _artRepository;
        private static IClientRepository _clientRepository;
        private static IDistributorRepository _distributorRepository;
        private static IGenreRepository _genreRepository;
        private static IPlaylistRepository _playlistRepository;
        private static ITrackRepository _trackRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _adminRepository = new AdminRepository(_appContext);
            _albumRepository = new AlbumRepository(_appContext);
            _artistRepository = new ArtistRepository(_appContext);
            _artRepository = new ArtRepository(_appContext);
            _clientRepository = new ClientRepository(_appContext);
            _distributorRepository = new DistributorRepository(_appContext);
            _genreRepository = new GenreRepository(_appContext);
            _playlistRepository = new PlaylistRepository(_appContext);
            _trackRepository = new TrackRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            Genre genre = new Genre(0, "Dubstep");
            _genreRepository.Add(genre);
        }
    }
}