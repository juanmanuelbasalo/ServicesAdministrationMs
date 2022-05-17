using ServicesAdministrationMs.Database.Entities;
using ServicesAdministrationMs.Database.Repositories;

namespace ServicesAdministrationMs.BusinessLayer.Services
{
    public class ServiceAdministrationService : IServiceAdministrationService
    {
        private readonly IGenericRepository _repository;
        public ServiceAdministrationService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public async Task PublishService(Guid businessUserId, Guid serviceCatalogId)
        {
            var businessUser = await _repository.FindAsync<BusinessUserEntity>(user => user.Id == businessUserId);
            var service = await _repository.FindAsync<ServiceCatalogEntity>(service => service.Id == serviceCatalogId);

            var serviceToAdd = new ServiceEntity 
            { 
                Title = "",
                Description = "",
                ServiceCatalog = service,
                ServiceCatalogId = service.Id,
                BusinessUser = businessUser, 
                BusinessUserId = businessUser.Id 
            };

            await _repository.SaveAsync("");
        } 
    }
}
