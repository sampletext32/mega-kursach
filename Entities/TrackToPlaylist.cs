namespace Entities
{
    public class TrackToPlaylist
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public virtual Track Track { get; set; }
        public int PlaylistId { get; set; }
        public virtual Playlist Playlist { get; set; }

        public TrackToPlaylist(Track track, Playlist playlist)
        {
            Track = track;
            Playlist = playlist;
        }

        public TrackToPlaylist()
        {
        }
    }
}