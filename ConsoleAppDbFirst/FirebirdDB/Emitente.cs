using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("EMITENTE                       ")]
    public partial class Emitente
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("XFANTASIA")]
        [StringLength(60)]
        public string Xfantasia { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Column("IEST")]
        [StringLength(14)]
        public string Iest { get; set; }
        [Column("IM")]
        [StringLength(15)]
        public string Im { get; set; }
        [Column("CNAE")]
        [StringLength(7)]
        public string Cnae { get; set; }
        [Column("CRT")]
        [StringLength(7)]
        public string Crt { get; set; }
        [Column("IND_ATIV")]
        [StringLength(2)]
        public string IndAtiv { get; set; }
        [Column("IND_NAT_PJ")]
        [StringLength(2)]
        public string IndNatPj { get; set; }
        [Column("XLOGR")]
        [StringLength(60)]
        public string Xlogr { get; set; }
        [Column("NUM")]
        [StringLength(60)]
        public string Num { get; set; }
        [Column("XCOMPL")]
        [StringLength(60)]
        public string Xcompl { get; set; }
        [Column("XBAIRRO")]
        [StringLength(60)]
        public string Xbairro { get; set; }
        [Column("CEP")]
        [StringLength(8)]
        public string Cep { get; set; }
        [Column("FONE")]
        [StringLength(14)]
        public string Fone { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("CMUN")]
        [StringLength(7)]
        public string Cmun { get; set; }
        [Column("XMUN")]
        [StringLength(256)]
        public string Xmun { get; set; }
        [Column("CPAIS")]
        [StringLength(7)]
        public string Cpais { get; set; }
        [Column("XPAIS")]
        [StringLength(256)]
        public string Xpais { get; set; }
        [Column("EMAIL")]
        [StringLength(120)]
        public string Email { get; set; }
        [Column("AC_ST")]
        [StringLength(14)]
        public string AcSt { get; set; }
        [Column("AL_ST")]
        [StringLength(14)]
        public string AlSt { get; set; }
        [Column("AM_ST")]
        [StringLength(14)]
        public string AmSt { get; set; }
        [Column("AP_ST")]
        [StringLength(14)]
        public string ApSt { get; set; }
        [Column("BA_ST")]
        [StringLength(14)]
        public string BaSt { get; set; }
        [Column("DF_ST")]
        [StringLength(14)]
        public string DfSt { get; set; }
        [Column("CE_ST")]
        [StringLength(14)]
        public string CeSt { get; set; }
        [Column("ES_ST")]
        [StringLength(14)]
        public string EsSt { get; set; }
        [Column("GO_ST")]
        [StringLength(14)]
        public string GoSt { get; set; }
        [Column("MA_ST")]
        [StringLength(14)]
        public string MaSt { get; set; }
        [Column("MT_ST")]
        [StringLength(14)]
        public string MtSt { get; set; }
        [Column("MS_ST")]
        [StringLength(14)]
        public string MsSt { get; set; }
        [Column("MG_ST")]
        [StringLength(14)]
        public string MgSt { get; set; }
        [Column("PA_ST")]
        [StringLength(14)]
        public string PaSt { get; set; }
        [Column("PB_ST")]
        [StringLength(14)]
        public string PbSt { get; set; }
        [Column("PE_ST")]
        [StringLength(14)]
        public string PeSt { get; set; }
        [Column("PR_ST")]
        [StringLength(14)]
        public string PrSt { get; set; }
        [Column("PI_ST")]
        [StringLength(14)]
        public string PiSt { get; set; }
        [Column("RJ_ST")]
        [StringLength(14)]
        public string RjSt { get; set; }
        [Column("RN_ST")]
        [StringLength(14)]
        public string RnSt { get; set; }
        [Column("RS_ST")]
        [StringLength(14)]
        public string RsSt { get; set; }
        [Column("RR_ST")]
        [StringLength(14)]
        public string RrSt { get; set; }
        [Column("RO_ST")]
        [StringLength(14)]
        public string RoSt { get; set; }
        [Column("SC_ST")]
        [StringLength(14)]
        public string ScSt { get; set; }
        [Column("SP_ST")]
        [StringLength(14)]
        public string SpSt { get; set; }
        [Column("SE_ST")]
        [StringLength(14)]
        public string SeSt { get; set; }
        [Column("TO_ST")]
        [StringLength(14)]
        public string ToSt { get; set; }
        [Column("LOGOMARCA")]
        public byte[] Logomarca { get; set; }
        [Column("IDTOKEN")]
        [StringLength(8)]
        public string Idtoken { get; set; }
        [Column("CSC")]
        [StringLength(36)]
        public string Csc { get; set; }
    }
}
