using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PAIS                           ")]
    public partial class Pais
    {
        [Column("CPAIS")]
        [StringLength(5)]
        public string Cpais { get; set; }
        [Required]
        [Column("XPAIS")]
        [StringLength(128)]
        public string Xpais { get; set; }
    }
}
