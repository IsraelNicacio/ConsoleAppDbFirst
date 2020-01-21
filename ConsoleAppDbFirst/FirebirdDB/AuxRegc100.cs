using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("AUX_REGC100                    ")]
    public partial class AuxRegc100
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
        public long CodPart { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Column("COD_SIT")]
        public int CodSit { get; set; }
        [Column("SER")]
        [StringLength(3)]
        public string Ser { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("CHV_NFE")]
        [StringLength(44)]
        public string ChvNfe { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("DT_E_S")]
        public DateTime DtES { get; set; }
        [Column("VL_DOC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlDoc { get; set; }
        [Required]
        [Column("IND_PGTO")]
        [StringLength(1)]
        public string IndPgto { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("VL_ABAT_NT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlAbatNt { get; set; }
        [Column("VL_MERC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlMerc { get; set; }
        [Required]
        [Column("IND_FRT")]
        [StringLength(1)]
        public string IndFrt { get; set; }
        [Column("VL_FRT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlFrt { get; set; }
        [Column("VL_SEG", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlSeg { get; set; }
        [Column("VL_OUT_DA", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlOutDa { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcms { get; set; }
        [Column("VL_BC_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcmsSt { get; set; }
        [Column("VL_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcmsSt { get; set; }
        [Column("VL_IPI", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIpi { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("VL_PIS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPisSt { get; set; }
        [Column("VL_COFINS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofinsSt { get; set; }
        [Required]
        [Column("NATOP")]
        [StringLength(60)]
        public string Natop { get; set; }
    }
}
