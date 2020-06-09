using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual CommonUserData CommonUserData { get; set; }
        public virtual DistributorData DistributorData { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }
        //TODO: Implement user library, replace playlists

        public User(
            string email,
            string password,
            CommonUserData commonUserData,
            DistributorData distributorData,
            ICollection<Playlist> playlists)
        {
            Email = email;
            Password = password;
            CommonUserData = commonUserData;
            DistributorData = distributorData;
            Playlists = playlists;
        }

        public User()
        {
        }
    }
}