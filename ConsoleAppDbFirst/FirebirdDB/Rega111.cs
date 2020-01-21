using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGA111                        ")]
    public partial class Rega111
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_PROC")]
        [StringLength(15)]
        public string NumProc { get; set; }
        [Required]
        [Column("IND_PROC")]
        [StringLength(1)]
        public string IndProc { get; set; }
    }
}
