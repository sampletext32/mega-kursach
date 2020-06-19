using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
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

            var genre = new Genre("Dubstep");
            _genreRepository.Add(genre);
            Console.WriteLine("Genre created");

            var country = new Country("Germany");
            _countryRepository.Add(country);
            Console.WriteLine("Country created");

            var userData = new CommonUserData("Egop", "Bird", "Tit", DateTime.Today);
            _commonUserDataRepository.Add(userData);
            Console.WriteLine("CommonUserData created");

            var userLibrary = new UserLibrary(new List<Album>(), new List<Playlist>());
            _userLibraryRepository.Add(userLibrary);
            Console.WriteLine("UserLibrary created");

            var art = new Art("image.jpg");
            _artRepository.Add(art);
            Console.WriteLine("Art created");

            var playlist = new Playlist("test playlist", "test description", art, userLibrary,
                new List<TrackToPlaylist>());
            _playlistRepository.Add(playlist);
            Console.WriteLine("Playlist created");

            userLibrary.Playlists.Add(playlist);
            _userLibraryRepository.Update(userLibrary);

            Console.WriteLine("Playlist added to UserLibrary");

            var distributorData = new DistributorData("test distributor", country, new List<Album>(),
                new List<ArtistToDistributor>());
            _distributorDataRepository.Add(distributorData);
            Console.WriteLine("DistributorData created");

            var album = new Album("test album", DateTime.Now, art, genre, distributorData, new List<Track>());
            _albumRepository.Add(album);
            Console.WriteLine("Album created");

            var track = new Track("Terror Drums", "test.mp3", 0, false, album, new List<TrackToPlaylist>());
            track.Playlists.Add(new TrackToPlaylist(track, playlist));
            _trackRepository.Add(track);
            Console.WriteLine("Track created");

            //foreach (var genre in _genreRepository.GetAll())
            //{
            //    Console.WriteLine(genre.Title);
            //}
            Console.ReadKey();
        }
    }
}