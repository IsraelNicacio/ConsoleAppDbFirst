using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGH005                        ")]
    public partial class Regh005
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DT_INV", TypeName = "DATE")]
        public DateTime DtInv { get; set; }
        [Required]
        [Column("MOT_INV")]
        [StringLength(2)]
        public string MotInv { get; set; }
    }
}
