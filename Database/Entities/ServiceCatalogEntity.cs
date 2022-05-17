using ServicesAdministrationMs.BusinessLayer.Enums;

namespace ServicesAdministrationMs.Database.Entities
{
    public class ServiceCatalogEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceTypeEnum ServiceType { get; set; }
    }
}
