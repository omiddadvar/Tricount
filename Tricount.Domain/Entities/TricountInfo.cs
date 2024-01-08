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
    public class TricountInfo : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TriCountInfoId {  get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(TricountCategory))]
        public int TricountCategoryId { get; set; }
        public TricountCategory TricountCategory { get; set; }

        [ForeignKey(nameof(Currency))]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        [StringLength(150)]
        public string Title { get; set; }
        public string Desciption { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
