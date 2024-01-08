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
    public class ExpenseParticipant : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ExpenseParticipantId { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Expense))]
        public long ExpenseId { get; set; }
        public Expense Expense { get; set; }

        public bool IsOwner { get; set; }
        public double DeptValue { get; set; }
    }
}
