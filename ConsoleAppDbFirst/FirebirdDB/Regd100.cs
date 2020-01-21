using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD100                        ")]
    public partial class Regd100
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("IND_OPER")]
        [StringLength(1)]
        public string IndOper { get; set; }
        [Required]
        [Column("IND_EMIT")]
        [StringLength(1)]
        public string IndEmit { get; set; }
        [Column("COD_PART")]
        public long? CodPart { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Column("COD_SIT")]
        public int CodSit { get; set; }
        [Column("SER")]
        [StringLength(3)]
        public string Ser { get; set; }
        [Column("SUB")]
        [StringLength(4)]
        public string Sub { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("CHV_CTE")]
        [StringLength(44)]
        public string ChvCte { get; set; }
        [Column("DT_DOC")]
        public DateTime? DtDoc { get; set; }
        [Column("DT_A_P")]
        public DateTime? DtAP { get; set; }
        [Column("TP_CT_E")]
        public int? TpCtE { get; set; }
        [Column("CHV_CTE_REF")]
        [StringLength(44)]
        public string ChvCteRef { get; set; }
        [Column("VL_DOC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDoc { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("IND_FRT")]
        [StringLength(1)]
        public string IndFrt { get; set; }
        [Column("VL_SERV", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlServ { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcms { get; set; }
        [Column("VL_NT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlNt { get; set; }
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
        [Column("CFOP")]
        public int? Cfop { get; set; }
        [Column("CST_ICMS")]
        public int? CstIcms { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
        [Column("COD_MUN_ORIG")]
        [StringLength(7)]
        public string CodMunOrig { get; set; }
        [Column("COD_MUN_DEST")]
        [StringLength(7)]
        public string CodMunDest { get; set; }
    }
}
