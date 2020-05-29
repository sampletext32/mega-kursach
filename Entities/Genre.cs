namespace Entities
{
    public class Genre : Entity
    {
        public Genre(int id, string title):base (id,title)
        {
            Id = id;
            Title = title;
        }
    }
}