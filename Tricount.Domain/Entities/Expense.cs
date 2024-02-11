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
    public class Expense : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExpenseId { get; set; }

        [ForeignKey(nameof(ExpenseType))]
        public int ExpenseTypeId { get; set; }
        public ExpenseType ExpenseType { get; set; }

        [ForeignKey(nameof(TricountInfo))]
        public int TricountInfoId { get; set; }
        public ExpenseType TricountInfo { get; set; }

        [StringLength(150)]
        public string Title { get; set; }
        public string Desciption { get; set; }
        public DateTime ExpenseDate { get; set; }
        public double TotalPrice { get; set; }

        public ICollection<ExpenseParticipant> ExpenseParticipants { get; set; }

    }
}
