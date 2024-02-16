using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricount.Domain.Common.Interfaces
{
    public interface IDomainEventDispatcher<TPrimaryKey>
    {
        Task DispatchAndClearEvents(IEnumerable<BaseEntity<TPrimaryKey>> entitiesWithEvents);
    }
}
