using System;

namespace Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        protected Entity(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}