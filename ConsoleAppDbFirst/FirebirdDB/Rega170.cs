using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGA170                        ")]
    public partial class Rega170
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_ITEM")]
        public int NumItem { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("DESC_COMPL")]
        [StringLength(512)]
        public string DescCompl { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("NAT_BC_CRED")]
        [StringLength(2)]
        public string NatBcCred { get; set; }
        [Column("IND_ORIG_CRED")]
        [StringLength(1)]
        public string IndOrigCred { get; set; }
        [Required]
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcPis { get; set; }
        [Column("ALIQ_PIS_POR", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqPisPor { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Required]
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("ALIQ_COFINS_POR", TypeName = "DECIMAL(6, 2)")]
        public decimal? AliqCofinsPor { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("COD_CCUS")]
        [StringLength(60)]
        public string CodCcus { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
