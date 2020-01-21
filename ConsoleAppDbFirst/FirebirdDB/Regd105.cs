using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD105                        ")]
    public partial class Regd105
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_D105")]
        public int IdD105 { get; set; }
        [Required]
        [Column("IND_NAT_FRT")]
        [StringLength(1)]
        public string IndNatFrt { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("CST_COFINS")]
        public int CstCofins { get; set; }
        [Column("NAT_BC_CRED")]
        [StringLength(2)]
        public string NatBcCred { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("ALIQ_COFINS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqCofins { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
