using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R07                            ")]
    public partial class R07
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("NUMERO_FABRICACAO")]
        [StringLength(20)]
        public string NumeroFabricacao { get; set; }
        [Column("MF_ADICIONAL", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string MfAdicional { get; set; }
        [Required]
        [Column("MODELO_ECF")]
        [StringLength(20)]
        public string ModeloEcf { get; set; }
        [Column("NUMERO_USUARIO")]
        public int NumeroUsuario { get; set; }
        [Column("COO")]
        public int Coo { get; set; }
        [Column("CCF")]
        public int Ccf { get; set; }
        [Column("GNF")]
        public int? Gnf { get; set; }
        [Column("DATA_INICIO_EMISSAO")]
        public DateTime DataInicioEmissao { get; set; }
        [Required]
        [Column("MEIO_PAGAMENTO")]
        [StringLength(15)]
        public string MeioPagamento { get; set; }
        [Column("VALOR_PAGO", TypeName = "DECIMAL(13, 2)")]
        public decimal ValorPago { get; set; }
        [Required]
        [Column("INDICADOR_ESTORNO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndicadorEstorno { get; set; }
        [Column("VALOR_ESTORNADO", TypeName = "DECIMAL(13, 2)")]
        public decimal ValorEstornado { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
