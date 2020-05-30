using System.Collections.Generic;
using Entities;

namespace Infrastucture
{
    public interface IArtRepository
    {
        Art Get(int id);

        void Add(Art art);
        void Update(Art art);
    }
}