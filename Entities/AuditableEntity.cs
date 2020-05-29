namespace Entities
{
    public abstract class AuditableEntity
    {
        public int Id { get; set; }

        protected AuditableEntity(int id)
        {
            Id = id;
        }
    }
}