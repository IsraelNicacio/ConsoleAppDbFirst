using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC505                        ")]
    public partial class Regc505
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_C505")]
        public int IdC505 { get; set; }
        [Column("CST_COFINS")]
        public int CstCofins { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("NAT_BC_CRED", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string NatBcCred { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcCofins { get; set; }
        [Column("ALIQ_COFINS", TypeName = "DECIMAL(18, 4)")]
        public decimal AliqCofins { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlCofins { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
