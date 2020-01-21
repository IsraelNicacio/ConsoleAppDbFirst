using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_TRIBUTACAO_FEDERAL  ")]
    public partial class NotafiscalTributacaoFederal
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("II_INDICADOR")]
        public short IiIndicador { get; set; }
        [Column("II_VBC")]
        [StringLength(128)]
        public string IiVbc { get; set; }
        [Column("II_VDESPADU")]
        [StringLength(128)]
        public string IiVdespadu { get; set; }
        [Column("II_VIOF")]
        [StringLength(128)]
        public string IiViof { get; set; }
        [Column("II_VII")]
        [StringLength(128)]
        public string IiVii { get; set; }
        [Column("IPI_INDICADOR")]
        public short IpiIndicador { get; set; }
        [Column("IPI_CNPJPROD")]
        [StringLength(128)]
        public string IpiCnpjprod { get; set; }
        [Column("IPI_CSELO")]
        [StringLength(128)]
        public string IpiCselo { get; set; }
        [Column("IPI_QSELO")]
        [StringLength(128)]
        public string IpiQselo { get; set; }
        [Column("IPI_CENQ")]
        [StringLength(128)]
        public string IpiCenq { get; set; }
        [Column("IPI_CST")]
        [StringLength(2)]
        public string IpiCst { get; set; }
        [Column("IPI_VBC")]
        [StringLength(128)]
        public string IpiVbc { get; set; }
        [Column("IPI_PIPI", TypeName = "DECIMAL(7, 4)")]
        public decimal? IpiPipi { get; set; }
        [Column("IPI_QUNID")]
        [StringLength(128)]
        public string IpiQunid { get; set; }
        [Column("IPI_VUNID", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVunid { get; set; }
        [Column("IPI_VIPI")]
        [StringLength(128)]
        public string IpiVipi { get; set; }
        [Column("IPI_VIPIDEVOL")]
        [StringLength(128)]
        public string IpiVipidevol { get; set; }
        [Column("PIS_INDICADOR")]
        public short PisIndicador { get; set; }
        [Column("PIS_CST")]
        [StringLength(2)]
        public string PisCst { get; set; }
        [Column("PIS_VBC")]
        [StringLength(128)]
        public string PisVbc { get; set; }
        [Column("PIS_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisPpis { get; set; }
        [Column("PIS_QBCPROD")]
        [StringLength(128)]
        public string PisQbcprod { get; set; }
        [Column("PIS_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisValiqprod { get; set; }
        [Column("PIS_VPIS")]
        [StringLength(128)]
        public string PisVpis { get; set; }
        [Column("PISST_INDICADOR")]
        public short PisstIndicador { get; set; }
        [Column("PISST_VBC")]
        [StringLength(128)]
        public string PisstVbc { get; set; }
        [Column("PISST_PPIS", TypeName = "DECIMAL(7, 4)")]
        public decimal? PisstPpis { get; set; }
        [Column("PISST_QBCPROD")]
        [StringLength(128)]
        public string PisstQbcprod { get; set; }
        [Column("PISST_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? PisstValiqprod { get; set; }
        [Column("PISST_VPIS")]
        [StringLength(128)]
        public string PisstVpis { get; set; }
        [Column("COFINS_INDICADOR")]
        public short CofinsIndicador { get; set; }
        [Column("COFINS_CST")]
        [StringLength(2)]
        public string CofinsCst { get; set; }
        [Column("COFINS_VBC")]
        [StringLength(128)]
        public string CofinsVbc { get; set; }
        [Column("COFINS_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsPcofins { get; set; }
        [Column("COFINS_QBCPROD")]
        [StringLength(128)]
        public string CofinsQbcprod { get; set; }
        [Column("COFINS_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsValiqprod { get; set; }
        [Column("COFINS_VCOFINS")]
        [StringLength(128)]
        public string CofinsVcofins { get; set; }
        [Column("COFINSST_INDICADOR")]
        public short CofinsstIndicador { get; set; }
        [Column("COFINSST_VBC")]
        [StringLength(128)]
        public string CofinsstVbc { get; set; }
        [Column("COFINSST_PCOFINS", TypeName = "DECIMAL(7, 4)")]
        public decimal? CofinsstPcofins { get; set; }
        [Column("COFINSST_QBCPROD")]
        [StringLength(128)]
        public string CofinsstQbcprod { get; set; }
        [Column("COFINSST_VALIQPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? CofinsstValiqprod { get; set; }
        [Column("COFINSST_VCOFINS")]
        [StringLength(128)]
        public string CofinsstVcofins { get; set; }
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
