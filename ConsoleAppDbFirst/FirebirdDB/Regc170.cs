using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC170                        ")]
    public partial class Regc170
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
        [Column("QTD", TypeName = "DECIMAL(18, 5)")]
        public decimal Qtd { get; set; }
        [Column("UNID")]
        [StringLength(6)]
        public string Unid { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("IND_MOV")]
        [StringLength(1)]
        public string IndMov { get; set; }
        [Column("CST_ICMS")]
        public int CstIcms { get; set; }
        [Column("CFOP")]
        public int Cfop { get; set; }
        [Column("COD_NAT")]
        public int? CodNat { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcms { get; set; }
        [Column("ALIQ_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcms { get; set; }
        [Column("VL_BC_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcmsSt { get; set; }
        [Column("ALIQ_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqSt { get; set; }
        [Column("VL_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcmsSt { get; set; }
        [Column("IND_APUR")]
        [StringLength(1)]
        public string IndApur { get; set; }
        [Column("CST_IPI")]
        [StringLength(2)]
        public string CstIpi { get; set; }
        [Column("COD_ENQ")]
        [StringLength(3)]
        public string CodEnq { get; set; }
        [Column("VL_BC_IPI", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIpi { get; set; }
        [Column("ALIQ_IPI", TypeName = "DECIMAL(6, 2)")]
        public decimal? AliqIpi { get; set; }
        [Column("VL_IPI", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIpi { get; set; }
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcPis { get; set; }
        [Column("ALIQ_PIS_POR", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqPisPor { get; set; }
        [Column("QUANT_BC_PIS", TypeName = "DECIMAL(18, 3)")]
        public decimal? QuantBcPis { get; set; }
        [Column("ALIQ_PIS_REAIS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqPisReais { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("ALIQ_COFINS_POR", TypeName = "DECIMAL(6, 2)")]
        public decimal? AliqCofinsPor { get; set; }
        [Column("QUANT_BC_COFINS", TypeName = "DECIMAL(18, 3)")]
        public decimal? QuantBcCofins { get; set; }
        [Column("ALIQ_COFINS_REAIS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqCofinsReais { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("VL_OPR", TypeName = "DECIMAL(18, 2)")]
        public decimal VlOpr { get; set; }
        [Column("VL_CUSTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCusto { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
        [Column("VL_ABAT_NT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlAbatNt { get; set; }
        [Column("COD_ANTECIPACAO")]
        public int? CodAntecipacao { get; set; }
    }
}
