using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Application.Interfaces.Repositories;
using Tricount.Domain.Common;
using Tricount.Persistence.DBContexts;

namespace Tricount.Persistence.Repositories
{
    public class UnitOfWork(TricountDBContext dbContext) : IUnitOfWork
    {
        private Hashtable _repositories;
        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IGenericRepository<T, TPrimaryKey> Repository<T, TPrimaryKey>() where T : BaseEntity<TPrimaryKey>
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<,>);

                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), dbContext);

                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T, TPrimaryKey>)_repositories[type];
        }

        public Task Rollback()
        {
            dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            return Task.CompletedTask;
        }
        public async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
