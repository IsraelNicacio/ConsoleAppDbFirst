using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R04                            ")]
    public partial class R04
    {
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
        [Column("CCF")]
        public int Ccf { get; set; }
        [Column("COO")]
        public int Coo { get; set; }
        [Column("DATA_INICIO_EMISSAO")]
        public DateTime DataInicioEmissao { get; set; }
        [Column("VALOR_SUBTOTAL", TypeName = "DECIMAL(14, 2)")]
        public decimal? ValorSubtotal { get; set; }
        [Column("DESCONTO_SUBTOTAL", TypeName = "DECIMAL(13, 2)")]
        public decimal? DescontoSubtotal { get; set; }
        [Column("TIPO_DESCONTO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string TipoDesconto { get; set; }
        [Column("ACRESCIMO_SUBTOTAL", TypeName = "DECIMAL(13, 2)")]
        public decimal? AcrescimoSubtotal { get; set; }
        [Column("TIPO_ACRESCIMO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string TipoAcrescimo { get; set; }
        [Column("VALOR_LIQUIDO", TypeName = "DECIMAL(14, 2)")]
        public decimal? ValorLiquido { get; set; }
        [Required]
        [Column("INDICADOR_CANCELAMENTO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndicadorCancelamento { get; set; }
        [Column("CANCELAMENTO_ACRESCIMO_SUBTOTAL", TypeName = "DECIMAL(13, 2)")]
        public decimal? CancelamentoAcrescimoSubtotal { get; set; }
        [Column("ORDEM_DESCONTO_ACRESCIMO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string OrdemDescontoAcrescimo { get; set; }
        [Column("NOME_ADQUIRENTE")]
        [StringLength(40)]
        public string NomeAdquirente { get; set; }
        [Column("CPF_CNPJ_ADQUIRENTE")]
        [StringLength(14)]
        public string CpfCnpjAdquirente { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
        [Column("CODIGO_AUXILIAR")]
        [StringLength(64)]
        public string CodigoAuxiliar { get; set; }
        [Column("MENSAGEM_ADICIONAL")]
        [StringLength(128)]
        public string MensagemAdicional { get; set; }
    }
}
