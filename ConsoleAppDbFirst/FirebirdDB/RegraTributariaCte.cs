using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGRA_TRIBUTARIA_CTE           ")]
    public partial class RegraTributariaCte
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("TIPO_SERVICO")]
        [StringLength(2)]
        public string TipoServico { get; set; }
        [Required]
        [Column("TIPO_OPERACAO")]
        [StringLength(2)]
        public string TipoOperacao { get; set; }
        [Required]
        [Column("INDICADOR_IE_TOMADOR")]
        [StringLength(2)]
        public string IndicadorIeTomador { get; set; }
        [Column("PADRAO")]
        public int? Padrao { get; set; }
        [Column("IDENTIFICACAO")]
        [StringLength(256)]
        public string Identificacao { get; set; }
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("NATUREZA_OPERACAO")]
        [StringLength(60)]
        public string NaturezaOperacao { get; set; }
        [Column("CALCULAR_IBPT")]
        public int CalcularIbpt { get; set; }
        [Column("ICMS_CST")]
        [StringLength(3)]
        public string IcmsCst { get; set; }
        [Column("ICMS_PREDBC", TypeName = "DECIMAL(7, 4)")]
        public decimal? IcmsPredbc { get; set; }
        [Column("ICMS_UF_DESTINO_BASE_CALCULO")]
        [StringLength(1024)]
        public string IcmsUfDestinoBaseCalculo { get; set; }
        [Column("ICMS_UF_DESTINO_DIFAL")]
        [StringLength(1024)]
        public string IcmsUfDestinoDifal { get; set; }
    }
}
