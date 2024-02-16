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
        public Guid ExpenseParticipantId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Expense))]
        public Guid ExpenseId { get; set; }
        public Expense Expense { get; set; }

        public bool IsOwner { get; set; } = false;

        [StringLength(100 ,ErrorMessage = "Participant name is too long")]
        public string? ParticipantName { get; set; }
        public double DeptValue { get; set; } = 0
    }
}
