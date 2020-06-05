using System;

namespace Entities
{
    public abstract class AuditableEntity
    {
        public long Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        protected AuditableEntity()
        {
        }
    }
}