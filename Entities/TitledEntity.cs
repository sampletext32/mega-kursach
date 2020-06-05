using System;

namespace Entities
{
    public abstract class TitledEntity : AuditableEntity
    {
        public string Title { get; set; }

        protected TitledEntity(string title)
        {
            Title = title;
        }

        public TitledEntity()
        {
        }
    }
}