namespace ServicesAdministrationMs.Database.Entities
{
    public class ServiceEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public BusinessUserEntity BusinessUser { get; set; }
        public Guid BusinessUserId { get; set; }
        public ServiceCatalogEntity ServiceCatalog { get; set; }
        public Guid ServiceCatalogId { get; set; }
    }
}
