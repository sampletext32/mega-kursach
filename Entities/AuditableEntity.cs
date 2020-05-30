using System;

namespace Entities
{
    public abstract class AuditableEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        protected AuditableEntity(int id)
        {
            Id = id;
        }

        public AuditableEntity()
        {
        }
    }
}