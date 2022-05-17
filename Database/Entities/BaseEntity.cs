namespace ServicesAdministrationMs.Database.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
