namespace ServicesAdministrationMs.Database.Entities
{
    public class BusinessUserEntity : BaseEntity
    {
        public List<ServiceEntity> Services { get; set; }
    }
}
