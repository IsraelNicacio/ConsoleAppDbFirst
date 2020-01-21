using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R05                            ")]
    public partial class R05
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
        [Column("NUMERO_ITEM")]
        public int NumeroItem { get; set; }
        [Required]
        [Column("CODIGO_PRODUTO_SERVICO")]
        [StringLength(60)]
        public string CodigoProdutoServico { get; set; }
        [Required]
        [Column("DESCRICAO_PRODUTO_SERVICO")]
        [StringLength(120)]
        public string DescricaoProdutoServico { get; set; }
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(3)]
        public string Unidade { get; set; }
        [Column("VALOR_UNITARIO")]
        public int ValorUnitario { get; set; }
        [Column("DESCONTO", TypeName = "DECIMAL(8, 2)")]
        public decimal Desconto { get; set; }
        [Column("ACRESCIMO", TypeName = "DECIMAL(8, 2)")]
        public decimal Acrescimo { get; set; }
        [Column("VALOR_LIQUIDO", TypeName = "DECIMAL(14, 2)")]
        public decimal ValorLiquido { get; set; }
        [Required]
        [Column("TOTALIZADOR_PARCIAL")]
        [StringLength(7)]
        public string TotalizadorParcial { get; set; }
        [Required]
        [Column("INDICADOR_CANCELAMENTO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndicadorCancelamento { get; set; }
        [Column("QUANTIDADE_CANCELADA", TypeName = "DECIMAL(7, 2)")]
        public decimal? QuantidadeCancelada { get; set; }
        [Column("VALOR_CANCELADO", TypeName = "DECIMAL(13, 2)")]
        public decimal? ValorCancelado { get; set; }
        [Column("CANCELAMENTO_ACRESCIMO_ITEM", TypeName = "DECIMAL(13, 2)")]
        public decimal? CancelamentoAcrescimoItem { get; set; }
        [Required]
        [Column("IAT", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Iat { get; set; }
        [Required]
        [Column("IPPT", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Ippt { get; set; }
        [Column("DECIMAIS_QUANTIDADE")]
        public int DecimaisQuantidade { get; set; }
        [Column("DECIMAIS_VALOR_UNITARIO")]
        public int DecimaisValorUnitario { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
