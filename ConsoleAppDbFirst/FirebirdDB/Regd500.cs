using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD500                        ")]
    public partial class Regd500
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("IND_OPER", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndOper { get; set; }
        [Required]
        [Column("IND_EMIT", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndEmit { get; set; }
        [Column("COD_PART")]
        public long CodPart { get; set; }
        [Required]
        [Column("COD_MOD", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string CodMod { get; set; }
        [Column("COD_SIT")]
        public int CodSit { get; set; }
        [Column("SER")]
        [StringLength(4)]
        public string Ser { get; set; }
        [Column("SUB")]
        [StringLength(11)]
        public string Sub { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("DT_A_P")]
        public DateTime DtAP { get; set; }
        [Column("VL_DOC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlDoc { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("VL_SERV", TypeName = "DECIMAL(18, 2)")]
        public decimal VlServ { get; set; }
        [Column("VL_SERV_NT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlServNt { get; set; }
        [Column("VL_TERC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlTerc { get; set; }
        [Column("VL_DA", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDa { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcms { get; set; }
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("TP_ASSINANTE", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string TpAssinante { get; set; }
        [Column("CFOP")]
        public int Cfop { get; set; }
        [Column("CST_ICMS")]
        public int CstIcms { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
