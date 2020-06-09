namespace Entities
{
    public class TrackToPlaylist
    {
        public int Id { get; set; }
        public virtual Track Track { get; set; }
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