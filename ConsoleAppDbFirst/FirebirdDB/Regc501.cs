using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC501                        ")]
    public partial class Regc501
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ID_C501")]
        public int IdC501 { get; set; }
        [Column("CST_PIS")]
        public int CstPis { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("NAT_BC_CRED", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string NatBcCred { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcPis { get; set; }
        [Column("ALIQ_PIS", TypeName = "DECIMAL(18, 4)")]
        public decimal AliqPis { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlPis { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
