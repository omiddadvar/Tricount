using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common.Interfaces;

namespace Tricount.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T,in TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {

        Task<T> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(TPrimaryKey id, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(T entity, CancellationToken cancellationToken = default);
        IEnumerable<T> Get(Expression<Func<T, bool>> Where = null
         , Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           params Expression<Func<T, object>>[] includeProperties);
    }
}
