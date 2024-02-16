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
    public class Currency : BaseEntity<int>
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string CurrencyName { get; set; }
        public double ConvertRate { get; set; }

    }
}
