using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD201                        ")]
    public partial class Regd201
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcPis { get; set; }
        [Column("ALIQ_PIS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqPis { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
