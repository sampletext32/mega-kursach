namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public CommonUserData CommonUserData { get; set; }
        public ArtistData ArtistData { get; set; }
        public DistributorData DistributorData { get; set; }

        public User(string email, string password, CommonUserData commonUserData, ArtistData artistData,
            DistributorData distributorData)
        {
            Email = email;
            Password = password;
            CommonUserData = commonUserData;
            ArtistData = artistData;
            DistributorData = distributorData;
        }

        public User()
        {
        }
    }
}