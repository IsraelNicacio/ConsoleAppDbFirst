using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_DET_IMPOSTO     ")]
    public partial class NotafiscalXmlDetImposto
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NITEM")]
        public int Nitem { get; set; }
        [Column("ICMS_ORIG")]
        public int? IcmsOrig { get; set; }
        [Column("ICMS_CST_CSOSN")]
        [StringLength(4)]
        public string IcmsCstCsosn { get; set; }
        [Column("ICMS_MODBC")]
        public int? IcmsModbc { get; set; }
        [Column("ICMS_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbc { get; set; }
        [Column("ICMS_PICMS", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPicms { get; set; }
        [Column("ICMS_VICMS", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicms { get; set; }
        [Column("ICMS_VBCFCP", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcfcp { get; set; }
        [Column("ICMS_PFCP", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPfcp { get; set; }
        [Column("ICMS_VFCP", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVfcp { get; set; }
        [Column("ICMS_PREDBC", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbc { get; set; }
        [Column("ICMS_PDIF", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPdif { get; set; }
        [Column("ICMS_VICMSDIF", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsVicmsdif { get; set; }
        [Column("ICMS_VICMSDESON", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmsdeson { get; set; }
        [Column("ICMS_MOTDESICMS")]
        public int? IcmsMotdesicms { get; set; }
        [Column("ICMS_PBCOP", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsPbcop { get; set; }
        [Column("ICMS_VICMSOP", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmsop { get; set; }
        [Column("ICMS_MODBCST")]
        public int? IcmsModbcst { get; set; }
        [Column("ICMS_PST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsPst { get; set; }
        [Column("ICMS_VICMSSUBSTITUTO", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmssubstituto { get; set; }
        [Column("ICMS_PMVAST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPmvast { get; set; }
        [Column("ICMS_PREDBCST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsPredbcst { get; set; }
        [Column("ICMS_VBCST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcst { get; set; }
        [Column("ICMS_PICMSST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsPicmsst { get; set; }
        [Column("ICMS_VICMSST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmsst { get; set; }
        [Column("ICMS_VBCFCPST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcfcpst { get; set; }
        [Column("ICMS_PFCPST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsPfcpst { get; set; }
        [Column("ICMS_VFCPST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsVfcpst { get; set; }
        [Column("ICMS_UFST")]
        [StringLength(2)]
        public string IcmsUfst { get; set; }
        [Column("ICMS_VBCSTRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcstret { get; set; }
        [Column("ICMS_VICMSSTRET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsVicmsstret { get; set; }
        [Column("ICMS_VBCFCPSTRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcfcpstret { get; set; }
        [Column("ICMS_PFCPSTRET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPfcpstret { get; set; }
        [Column("ICMS_VFCPSTRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVfcpstret { get; set; }
        [Column("ICMS_PCREDSN", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPcredsn { get; set; }
        [Column("ICMS_VCREDICMSSN", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVcredicmssn { get; set; }
        [Column("ICMS_VBCSTDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcstdest { get; set; }
        [Column("ICMS_VICMSSTDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmsstdest { get; set; }
        [Column("ICMS_PREDBCEFET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbcefet { get; set; }
        [Column("ICMS_VBCEFET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVbcefet { get; set; }
        [Column("ICMS_PICMSEFET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPicmsefet { get; set; }
        [Column("ICMS_VICMSEFET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsVicmsefet { get; set; }
        [Column("ICMSUFDEST_VBCUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsufdestVbcufdest { get; set; }
        [Column("ICMSUFDEST_VBCFCPUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsufdestVbcfcpufdest { get; set; }
        [Column("ICMSUFDEST_PFCPUFDEST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPfcpufdest { get; set; }
        [Column("ICMSUFDEST_PICMSUFDEST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsufdest { get; set; }
        [Column("ICMSUFDEST_PICMSINTER", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsinter { get; set; }
        [Column("ICMSUFDEST_PICMSINTERPART", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsinterpart { get; set; }
        [Column("ICMSUFDEST_VFCPUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsufdestVfcpufdest { get; set; }
        [Column("ICMSUFDEST_VICMSUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsufdestVicmsufdest { get; set; }
        [Column("ICMSUFDEST_VICMSUFREMET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IcmsufdestVicmsufremet { get; set; }
        [Column("IPI_CST")]
        [StringLength(4)]
        public string IpiCst { get; set; }
        [Column("IPI_CNPJPROD")]
        [StringLength(14)]
        public string IpiCnpjprod { get; set; }
        [Column("IPI_CSELO")]
        [StringLength(60)]
        public string IpiCselo { get; set; }
        [Column("IPI_QSELO")]
        [StringLength(12)]
        public string IpiQselo { get; set; }
        [Column("IPI_CENQ")]
        [StringLength(3)]
        public string IpiCenq { get; set; }
        [Column("IPI_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVbc { get; set; }
        [Column("IPI_PIPI", TypeName = "DECIMAL(7, 4)")]
        public decimal? IpiPipi { get; set; }
        [Column("IPI_QUNID", TypeName = "DECIMAL(15, 4)")]
        public decimal? IpiQunid { get; set; }
        [Column("IPI_VUNID", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVunid { get; set; }
        [Column("IPI_VIPI", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVipi { get; set; }
        [Column("IPI_VIPIDEVOL", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVipidevol { get; set; }
        [Column("II_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? IiVbc { get; set; }
        [Column("II_VDESPADU", TypeName = "DECIMAL(15, 2)")]
        public decimal? IiVdespadu { get; set; }
        [Column("II_VIOF", TypeName = "DECIMAL(15, 2)")]
        public decimal? IiViof { get; set; }
        [Column("II_VII", TypeName = "DECIMAL(15, 2)")]
        public decimal? IiVii { get; set; }
        [Column("PIS_CST")]
        [StringLength(60)]
        public string PisCst { get; set; }
        [Column("PIS_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisVbc { get; set; }
        [Column("PIS_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisPpis { get; set; }
        [Column("PIS_QBCPROD", TypeName = "DECIMAL(15, 4)")]
        public decimal? PisQbcprod { get; set; }
        [Column("PIS_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisValiqprod { get; set; }
        [Column("PIS_VPIS", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisVpis { get; set; }
        [Column("PISST_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisstVbc { get; set; }
        [Column("PISST_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisstPpis { get; set; }
        [Column("PISST_QBCPROD", TypeName = "DECIMAL(15, 4)")]
        public decimal? PisstQbcprod { get; set; }
        [Column("PISST_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisstValiqprod { get; set; }
        [Column("PISST_VPIS", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisstVpis { get; set; }
        [Column("COFINS_CST")]
        [StringLength(60)]
        public string CofinsCst { get; set; }
        [Column("COFINS_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsVbc { get; set; }
        [Column("COFINS_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsPcofins { get; set; }
        [Column("COFINS_QBCPROD", TypeName = "DECIMAL(15, 4)")]
        public decimal? CofinsQbcprod { get; set; }
        [Column("COFINS_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsValiqprod { get; set; }
        [Column("COFINS_VCOFINS", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsVcofins { get; set; }
        [Column("COFINSST_VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsstVbc { get; set; }
        [Column("COFINSST_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsstPcofins { get; set; }
        [Column("COFINSST_QBCPROD", TypeName = "DECIMAL(15, 4)")]
        public decimal? CofinsstQbcprod { get; set; }
        [Column("COFINSST_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsstValiqprod { get; set; }
        [Column("COFINSST_VCOFINS", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsstVcofins { get; set; }
        [Column("ISSQN_VBC", TypeName = "DECIMAL(15, 4)")]
        public decimal? IssqnVbc { get; set; }
        [Column("ISSQN_VALIQ", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnValiq { get; set; }
        [Column("ISSQN_VISSQN", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVissqn { get; set; }
        [Column("ISSQN_CMUNFG")]
        [StringLength(7)]
        public string IssqnCmunfg { get; set; }
        [Column("ISSQN_CLISTSERV")]
        [StringLength(7)]
        public string IssqnClistserv { get; set; }
        [Column("ISSQN_VDEDUCAO", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVdeducao { get; set; }
        [Column("ISSQN_VOUTRO", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVoutro { get; set; }
        [Column("ISSQN_VDESCINCOND", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVdescincond { get; set; }
        [Column("ISSQN_VDESCCOND", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVdesccond { get; set; }
        [Column("ISSQN_VISSRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? IssqnVissret { get; set; }
        [Column("ISSQN_INDISS")]
        public int? IssqnIndiss { get; set; }
        [Column("ISSQN_CSERVICO")]
        [StringLength(20)]
        public string IssqnCservico { get; set; }
        [Column("ISSQN_CMUN")]
        [StringLength(7)]
        public string IssqnCmun { get; set; }
        [Column("ISSQN_CPAIS")]
        [StringLength(4)]
        public string IssqnCpais { get; set; }
        [Column("ISSQN_NPROCESSO")]
        [StringLength(30)]
        public string IssqnNprocesso { get; set; }
        [Column("ISSQN_INDINCENTIVO")]
        public int? IssqnIndincentivo { get; set; }
    }
}
