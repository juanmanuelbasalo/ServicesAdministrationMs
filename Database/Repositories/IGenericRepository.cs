﻿using ServicesAdministrationMs.Database.Entities;
using System.Linq.Expressions;

namespace ServicesAdministrationMs.Database.Repositories
{
    public interface IGenericRepository
    {
        IQueryable<TEntity> FindAll<TEntity>(Expression<Func<TEntity, bool>> searchTerm) where TEntity : BaseEntity;
        Task<TEntity> FindAsync<TEntity>(Expression<Func<TEntity, bool>> searchTerm) where TEntity : BaseEntity;
        IEnumerable<TEntity> GetAllReadOnly<TEntity>() where TEntity : BaseEntity;
        void Insert<TEntity>(TEntity entity) where TEntity : BaseEntity;
        Task<bool> SaveAsync(string userEmail);
    }
}
