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
    public class User : BaseAuditableEntity
    {
        [Key]
        public long UserId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string UserName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }
        public byte[] Salt { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
