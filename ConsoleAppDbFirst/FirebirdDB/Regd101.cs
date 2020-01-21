using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD101                        ")]
    public partial class Regd101
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_D101")]
        public int IdD101 { get; set; }
        [Required]
        [Column("IND_NAT_FRT")]
        [StringLength(1)]
        public string IndNatFrt { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("CST_PIS")]
        public int CstPis { get; set; }
        [Column("NAT_BC_CRED")]
        [StringLength(2)]
        public string NatBcCred { get; set; }
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
