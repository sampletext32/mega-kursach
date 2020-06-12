namespace Entities
{
    public class ArtistToDistributor
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public virtual ArtistData Artist { get; set; }
        public int DistributorId { get; set; }
        public virtual DistributorData Distributor { get; set; }

        public ArtistToDistributor(ArtistData artist, DistributorData distributor)
        {
            Artist = artist;
            Distributor = distributor;
        }

        public ArtistToDistributor()
        {
        }
    }
}