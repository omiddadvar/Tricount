using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common.Interfaces;

namespace Tricount.Domain.Common
{
    public class BaseAuditableEntity<TPrimaryKey> : BaseEntity<TPrimaryKey>, IAuditableEntity 
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
