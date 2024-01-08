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
    public class Document : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DocumenttId { get; set; }

        [ForeignKey(nameof(DocumentType))]
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Expense))]
        public long ExpenseId { get; set; }
        public Expense Expense { get; set; }

        [StringLength(4000)]
        public string Filename { get; set; }
        public Guid FileGuid { get; set; }
    }
}
