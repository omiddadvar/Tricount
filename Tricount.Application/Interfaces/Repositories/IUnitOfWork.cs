using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common;

namespace Tricount.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T ,TPrimaryKey> Repository<T, TPrimaryKey>() where T : BaseEntity;
        Task<int> Save(CancellationToken cancellationToken);
        Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);
        Task Rollback();
    }
}
