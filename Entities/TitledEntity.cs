using System;

namespace Entities
{
    public abstract class TitledEntity : AuditableEntity
    {
        public string Title { get; set; }

        protected TitledEntity(int id, string title) : base(id)
        {
            Title = title;
        }
    }
}