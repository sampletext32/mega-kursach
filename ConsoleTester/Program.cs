using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using Entities;
using Infrastructure;
using Infrastructure.IRepositories;
using Infrastructure.Repositories;

//using Infrastructure.IRepositories;
//using Infrastructure.Repositories;

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
        private static IAlbumRepository _albumRepository;
        private static IArtRepository _artRepository;
        private static IArtistDataRepository _artistDataRepository;
        private static ICommonUserDataRepository _commonUserDataRepository;
        private static ICountryRepository _countryRepository;
        private static IDistributorDataRepository _distributorDataRepository;
        private static IGenreRepository _genreRepository;
        private static IPlaylistRepository _playlistRepository;
        private static ITrackRepository _trackRepository;
        private static IUserRepository _userRepository;
        private static IUserLibraryRepository _userLibraryRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _albumRepository = new AlbumRepository(_appContext);
            _artRepository = new ArtRepository(_appContext);
            _artistDataRepository = new ArtistDataRepository(_appContext);
            _commonUserDataRepository = new CommonUserDataRepository(_appContext);
            _countryRepository = new CountryRepository(_appContext);
            _distributorDataRepository = new DistributorDataRepository(_appContext);
            _genreRepository = new GenreRepository(_appContext);
            _playlistRepository = new PlaylistRepository(_appContext);
            _trackRepository = new TrackRepository(_appContext);
            _userRepository = new UserRepository(_appContext);
            _userLibraryRepository = new UserLibraryRepository(_appContext);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            _countryRepository.Add(new Country("Russia"));

            //foreach (var genre in _genreRepository.GetAll())
            //{
            //    Console.WriteLine(genre.Title);
            //}
        }
    }
}