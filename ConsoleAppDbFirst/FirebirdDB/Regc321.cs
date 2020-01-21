using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC321                        ")]
    public partial class Regc321
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("REGC300_ID")]
        public int Regc300Id { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Required]
        [Column("CST_ICMS", TypeName = "CHAR(3) CHARACTER SET UNICODE_FSS")]
        public string CstIcms { get; set; }
        [Column("CFOP")]
        public int Cfop { get; set; }
        [Column("ALIQ_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqIcms { get; set; }
        [Column("QTD", TypeName = "DECIMAL(18, 3)")]
        public decimal Qtd { get; set; }
        [Required]
        [Column("UNID")]
        [StringLength(6)]
        public string Unid { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcms { get; set; }
        [Column("VL_RED_BC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlRedBc { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
    }
}
