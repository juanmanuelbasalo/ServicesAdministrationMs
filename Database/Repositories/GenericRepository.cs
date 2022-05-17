using Microsoft.EntityFrameworkCore;
using ServicesAdministrationMs.Database.Entities;
using System.Linq.Expressions;

namespace ServicesAdministrationMs.Database.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ServiceAdministrationContext _dbContext;
        public GenericRepository(ServiceAdministrationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetAllReadOnly<TEntity>() where TEntity : BaseEntity
        {
            var entities = _dbContext.Set<TEntity>().AsNoTracking();
            return entities;
        }
        public void Insert<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            var entities = _dbContext.Set<TEntity>();
            entities.Add(entity);
        } 
        public async Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> searchTerm) where TEntity : BaseEntity
        {
            var entities = _dbContext.Set<TEntity>();
            var entity = await entities.FirstOrDefaultAsync(searchTerm);

            return entity;
        }
        public IQueryable<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> searchTerm) where TEntity : BaseEntity
        {
            var entities = _dbContext.Set<TEntity>();
            var allEntities = entities.Where(searchTerm);

            return allEntities;
        }
        public async Task<bool> SaveAsync(string userEmail)
        {
            var result = await _dbContext.SaveChangesAsync(userEmail);
            return result;
        }
    }
}
