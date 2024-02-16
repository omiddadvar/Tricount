using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Common;
using Tricount.Domain.Common.Interfaces;
using Tricount.Persistence.DBContexts;

namespace Tricount.Persistence.Repositories
{
    public class GenericRepository<T, TPrimaryKey> : IGenericRepository<T, TPrimaryKey> 
        where T : BaseEntity<TPrimaryKey>
        where TPrimaryKey : class
    {
        private readonly TricountDBContext _dBContext;

        public GenericRepository(TricountDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<T> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default)
        {
            return await _dBContext.Set<T>().FindAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dBContext.Set<T>().ToArrayAsync(cancellationToken);
        }

        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dBContext.AddAsync(entity,cancellationToken);
            return entity;
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _dBContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (cancellationToken.IsCancellationRequested) return false;
            _dBContext.Set<T>().Remove(entity);
            return true;
        }
        public async Task<bool> DeleteAsync(TPrimaryKey id, CancellationToken cancellationToken = default)
        {
            var entity = await _dBContext.Set<T>().FindAsync(id,cancellationToken);
            
            if (entity is null || cancellationToken.IsCancellationRequested) return false;
            _dBContext.Set<T>().Remove(entity);
            return true;
        }
        public async Task<bool> ExistsAsync(T entity, CancellationToken cancellationToken = default)
        {
            return await _dBContext.Set<T>().AnyAsync(cancellationToken);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> Where = null
          , Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dBContext.Set<T>();

            if (Where != null)
            {
                query = query.Where(Where);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
