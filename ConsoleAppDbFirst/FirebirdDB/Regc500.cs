using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC500                        ")]
    public partial class Regc500
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
        [StringLength(4)]
        public string Ser { get; set; }
        [Column("SUB")]
        public int? Sub { get; set; }
        [Required]
        [Column("COD_CONS")]
        [StringLength(2)]
        public string CodCons { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("DT_E_S")]
        public DateTime DtES { get; set; }
        [Column("VL_DOC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlDoc { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("VL_FORN", TypeName = "DECIMAL(18, 2)")]
        public decimal VlForn { get; set; }
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
        [Column("VL_BC_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIcmsSt { get; set; }
        [Column("VL_ICMS_ST", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIcmsSt { get; set; }
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("TP_LIGACAO")]
        public int? TpLigacao { get; set; }
        [Column("COD_GRUPO_TENSAO")]
        [StringLength(2)]
        public string CodGrupoTensao { get; set; }
        [Column("CFOP")]
        public int Cfop { get; set; }
        [Column("CST_ICMS")]
        public int CstIcms { get; set; }
    }
}
