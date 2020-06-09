namespace Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public int Plays { get; set; }
        public bool IsExplicit { get; set; }
        public Album Album { get; set; }

        public Track(string title, string path, int plays, bool isExplicit, Album album)
        {
            Title = title;
            Path = path;
            Plays = plays;
            IsExplicit = isExplicit;
            Album = album;
        }

        public Track()
        {
        }
    }
}