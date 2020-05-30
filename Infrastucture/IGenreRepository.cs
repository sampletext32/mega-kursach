using Entities;

namespace Infrastucture
{
    public interface IGenreRepository
    {
        Genre Get(int id);

        void Add(Genre genre);

        void Update(Genre genre);

        void Remove(Genre genre);
    }
}