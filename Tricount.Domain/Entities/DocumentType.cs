using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common;

namespace Tricount.Domain.Entities
{
    public class DocumentType : BaseEntity
    {
        [Key]
        public int DocumentTypeId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string DocumentTypeName { get; set; }
    }
}
