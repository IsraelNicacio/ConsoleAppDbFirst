using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("AUX_REGC140                    ")]
    public partial class AuxRegc140
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("IND_EMIT")]
        [StringLength(1)]
        public string IndEmit { get; set; }
        [Required]
        [Column("IND_TIT")]
        [StringLength(2)]
        public string IndTit { get; set; }
        [Column("DESC_TIT")]
        [StringLength(512)]
        public string DescTit { get; set; }
        [Required]
        [Column("NUM_TIT")]
        [StringLength(512)]
        public string NumTit { get; set; }
        [Column("QTD_PARC")]
        public int QtdParc { get; set; }
        [Column("VL_TIT", TypeName = "DECIMAL(18, 2)")]
        public decimal VlTit { get; set; }
    }
}
