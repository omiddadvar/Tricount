﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tricount.Domain.Common;

namespace Tricount.Domain.Entities
{
    public class TricountCategory : BaseEntity
    {
        [Key]
        public int TricountCategoryId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string TricountCategoryName { get; set; }
    }
}
