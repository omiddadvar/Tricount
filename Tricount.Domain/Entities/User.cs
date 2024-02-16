using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common;

namespace Tricount.Domain.Entities
{
    public class User : BaseAuditableEntity<Guid>
    {
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }
        [MaxLength(16)]
        public byte[] Salt { get; set; }
        [MaxLength(64)]
        public byte[] PasswordHash { get; set; }

        public ICollection<TricountInfo> Tricounts { get; set; }
        public ICollection<ExpenseParticipant> ExpenseParticipants { get; set; }

    }
}
