using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_TRIBUTACAO_ESTADUAL ")]
    public partial class NotafiscalTributacaoEstadual
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("INDICADOR_REGIME")]
        public short IndicadorRegime { get; set; }
        [Column("ICMS_INDICADOR")]
        public short IcmsIndicador { get; set; }
        [Column("ICMS_ORIG")]
        [StringLength(32)]
        public string IcmsOrig { get; set; }
        [Column("ICMS_CST_CSOSN")]
        [StringLength(4)]
        public string IcmsCstCsosn { get; set; }
        [Column("ICMS_MODBC")]
        public short? IcmsModbc { get; set; }
        [Column("ICMS_VBC")]
        [StringLength(128)]
        public string IcmsVbc { get; set; }
        [Column("ICMS_PICMS", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPicms { get; set; }
        [Column("ICMS_VICMS")]
        [StringLength(128)]
        public string IcmsVicms { get; set; }
        [Column("ICMS_VBCFCP")]
        [StringLength(128)]
        public string IcmsVbcfcp { get; set; }
        [Column("ICMS_PFCP", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPfcp { get; set; }
        [Column("ICMS_VFCP")]
        [StringLength(128)]
        public string IcmsVfcp { get; set; }
        [Column("ICMS_PREDBC", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbc { get; set; }
        [Column("ICMS_PDIF", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPdif { get; set; }
        [Column("ICMS_VICMSDIF")]
        [StringLength(128)]
        public string IcmsVicmsdif { get; set; }
        [Column("ICMS_VICMSDESON")]
        [StringLength(128)]
        public string IcmsVicmsdeson { get; set; }
        [Column("ICMS_MOTDESICMS")]
        public short? IcmsMotdesicms { get; set; }
        [Column("ICMS_PBCOP", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPbcop { get; set; }
        [Column("ICMS_VICMSOP")]
        [StringLength(128)]
        public string IcmsVicmsop { get; set; }
        [Column("ICMS_MODBCST")]
        public short? IcmsModbcst { get; set; }
        [Column("ICMS_PST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPst { get; set; }
        [Column("ICMS_VICMSSUBSTITUTO")]
        [StringLength(128)]
        public string IcmsVicmssubstituto { get; set; }
        [Column("ICMS_PMVAST")]
        [StringLength(128)]
        public string IcmsPmvast { get; set; }
        [Column("ICMS_PREDBCST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbcst { get; set; }
        [Column("ICMS_VBCST")]
        [StringLength(128)]
        public string IcmsVbcst { get; set; }
        [Column("ICMS_PICMSST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPicmsst { get; set; }
        [Column("ICMS_VICMSST")]
        [StringLength(128)]
        public string IcmsVicmsst { get; set; }
        [Column("ICMS_VBCFCPST")]
        [StringLength(128)]
        public string IcmsVbcfcpst { get; set; }
        [Column("ICMS_PFCPST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPfcpst { get; set; }
        [Column("ICMS_VFCPST")]
        [StringLength(128)]
        public string IcmsVfcpst { get; set; }
        [Column("ICMS_UFST")]
        [StringLength(128)]
        public string IcmsUfst { get; set; }
        [Column("ICMS_VBCSTRET")]
        [StringLength(128)]
        public string IcmsVbcstret { get; set; }
        [Column("ICMS_VICMSSTRET")]
        [StringLength(128)]
        public string IcmsVicmsstret { get; set; }
        [Column("ICMS_VBCFCPSTRET")]
        [StringLength(128)]
        public string IcmsVbcfcpstret { get; set; }
        [Column("ICMS_PFCPSTRET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPfcpstret { get; set; }
        [Column("ICMS_VFCPSTRET")]
        [StringLength(128)]
        public string IcmsVfcpstret { get; set; }
        [Column("ICMS_PCREDSN", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPcredsn { get; set; }
        [Column("ICMS_VCREDICMSSN")]
        [StringLength(128)]
        public string IcmsVcredicmssn { get; set; }
        [Column("ICMS_VBCSTDEST")]
        [StringLength(128)]
        public string IcmsVbcstdest { get; set; }
        [Column("ICMS_VICMSSTDEST")]
        [StringLength(128)]
        public string IcmsVicmsstdest { get; set; }
        [Column("ICMS_PREDBCEFET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbcefet { get; set; }
        [Column("ICMS_VBCEFET")]
        [StringLength(128)]
        public string IcmsVbcefet { get; set; }
        [Column("ICMS_PICMSEFET", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPicmsefet { get; set; }
        [Column("ICMS_VICMSEFET")]
        [StringLength(128)]
        public string IcmsVicmsefet { get; set; }
        [Column("ICMSUFDEST_INDICADOR")]
        public short IcmsufdestIndicador { get; set; }
        [Column("ICMSUFDEST_VBCUFDEST")]
        [StringLength(128)]
        public string IcmsufdestVbcufdest { get; set; }
        [Column("ICMSUFDEST_PICMSUFDEST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsufdest { get; set; }
        [Column("ICMSUFDEST_PICMSINTER", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsinter { get; set; }
        [Column("ICMSUFDEST_VDIFAL")]
        [StringLength(128)]
        public string IcmsufdestVdifal { get; set; }
        [Column("ICMSUFDEST_PICMSINTERPART", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPicmsinterpart { get; set; }
        [Column("ICMSUFDEST_VICMSUFDEST")]
        [StringLength(128)]
        public string IcmsufdestVicmsufdest { get; set; }
        [Column("ICMSUFDEST_VICMSUFREMET")]
        [StringLength(128)]
        public string IcmsufdestVicmsufremet { get; set; }
        [Column("ICMSUFDEST_VBCFCPUFDEST")]
        [StringLength(128)]
        public string IcmsufdestVbcfcpufdest { get; set; }
        [Column("ICMSUFDEST_PFCPUFDEST", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsufdestPfcpufdest { get; set; }
        [Column("ICMSUFDEST_VFCPUFDEST")]
        [StringLength(128)]
        public string IcmsufdestVfcpufdest { get; set; }
        [Column("CRIACAO_USUARIO_ID")]
        public int? CriacaoUsuarioId { get; set; }
        [Column("CRIACAO_DATA_HORA")]
        public DateTime? CriacaoDataHora { get; set; }
        [Column("ULTIMA_ATUALIZACAO_USUARIO_ID")]
        public int? UltimaAtualizacaoUsuarioId { get; set; }
        [Column("ULTIMA_ATUALIZACAO_DATA_HORA")]
        public DateTime? UltimaAtualizacaoDataHora { get; set; }
    }
}
