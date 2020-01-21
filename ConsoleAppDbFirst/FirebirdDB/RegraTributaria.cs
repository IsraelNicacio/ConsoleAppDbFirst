using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGRA_TRIBUTARIA               ")]
    public partial class RegraTributaria
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("IDENTIFICACAO")]
        [StringLength(256)]
        public string Identificacao { get; set; }
        [Required]
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("ICMS_ORIG")]
        [StringLength(1)]
        public string IcmsOrig { get; set; }
        [Column("ICMS_CST_CSOSN")]
        [StringLength(3)]
        public string IcmsCstCsosn { get; set; }
        [Column("ICMS_MODBC")]
        [StringLength(1)]
        public string IcmsModbc { get; set; }
        [Column("ICMS_PREDBC", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbc { get; set; }
        [Column("ICMS_PDIF", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPdif { get; set; }
        [Column("ICMS_PCREDSN", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPcredsn { get; set; }
        [Column("ICMS_MOTDESICMS")]
        [StringLength(2)]
        public string IcmsMotdesicms { get; set; }
        [Column("ICMS_MODBCST")]
        [StringLength(1)]
        public string IcmsModbcst { get; set; }
        [Column("ICMS_PMVAST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPmvast { get; set; }
        [Column("ICMS_PREDBCST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbcst { get; set; }
        [Column("IPI_CST")]
        [StringLength(2)]
        public string IpiCst { get; set; }
        [Column("IPI_PIPI", TypeName = "DECIMAL(7, 4)")]
        public decimal? IpiPipi { get; set; }
        [Column("IPI_VUNID", TypeName = "DECIMAL(11, 4)")]
        public decimal? IpiVunid { get; set; }
        [Column("IPI_CLENQ")]
        [StringLength(5)]
        public string IpiClenq { get; set; }
        [Column("IPI_CNPJPROD")]
        [StringLength(14)]
        public string IpiCnpjprod { get; set; }
        [Column("IPI_CSELO")]
        [StringLength(60)]
        public string IpiCselo { get; set; }
        [Column("IPI_CENQ")]
        [StringLength(3)]
        public string IpiCenq { get; set; }
        [Column("PIS_CST")]
        [StringLength(2)]
        public string PisCst { get; set; }
        [Column("PIS_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisPpis { get; set; }
        [Column("PIS_VALIQPROD", TypeName = "DECIMAL(11, 4)")]
        public decimal? PisValiqprod { get; set; }
        [Column("PIS_ST_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisStPpis { get; set; }
        [Column("PIS_ST_VALIQPROD", TypeName = "DECIMAL(11, 4)")]
        public decimal? PisStValiqprod { get; set; }
        [Column("COFINS_CST")]
        [StringLength(2)]
        public string CofinsCst { get; set; }
        [Column("COFINS_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsPcofins { get; set; }
        [Column("COFINS_VALIQPROD", TypeName = "DECIMAL(11, 4)")]
        public decimal? CofinsValiqprod { get; set; }
        [Column("COFINS_ST_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsStPcofins { get; set; }
        [Column("COFINS_ST_VALIQPROD", TypeName = "DECIMAL(11, 4)")]
        public decimal? CofinsStValiqprod { get; set; }
        [Column("ISSQN_VALIQ", TypeName = "DECIMAL(7, 4)")]
        public decimal? IssqnValiq { get; set; }
        [Column("ISSQN_CMUNFG")]
        [StringLength(7)]
        public string IssqnCmunfg { get; set; }
        [Column("ISSQN_CLISTSERV")]
        [StringLength(5)]
        public string IssqnClistserv { get; set; }
        [Column("ISSQN_INDISS")]
        [StringLength(1)]
        public string IssqnIndiss { get; set; }
        [Column("ISSQN_CSERVICO")]
        [StringLength(20)]
        public string IssqnCservico { get; set; }
        [Column("ISSQN_CMUN")]
        [StringLength(7)]
        public string IssqnCmun { get; set; }
        [Column("ISSQN_CPAIS")]
        [StringLength(4)]
        public string IssqnCpais { get; set; }
        [Column("ISSQN_INDINCENTIVO")]
        [StringLength(1)]
        public string IssqnIndincentivo { get; set; }
        [Column("ICMS_UF_DESTINO_BASE_CALCULO")]
        [StringLength(1024)]
        public string IcmsUfDestinoBaseCalculo { get; set; }
        [Column("ICMS_UF_DESTINO_DIFAL")]
        [StringLength(1024)]
        public string IcmsUfDestinoDifal { get; set; }
    }
}
