using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("LANCAMENTO                     ")]
    public partial class Lancamento
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("OPERACAO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Operacao { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("PLANO_CONTAS_ID")]
        public int PlanoContasId { get; set; }
        [Column("CENTRO_CUSTO_LUCRO")]
        public long? CentroCustoLucro { get; set; }
        [Column("TIPO_DOCUMENTO_FINANCEIRO_ID")]
        public int? TipoDocumentoFinanceiroId { get; set; }
        [Column("FORMA_PAGAMENTO_ID")]
        public int FormaPagamentoId { get; set; }
        [Column("CONTA_CAPITAL_ID")]
        public int ContaCapitalId { get; set; }
        [Required]
        [Column("MOEDA_ID")]
        [StringLength(6)]
        public string MoedaId { get; set; }
        [Column("DATA_REGISTRO")]
        public DateTime DataRegistro { get; set; }
        [Column("DATA_COMPETENCIA")]
        public DateTime DataCompetencia { get; set; }
        [Column("DATA_VENCIMENTO")]
        public DateTime DataVencimento { get; set; }
        [Column("NUMERO_DOCUMENTO")]
        [StringLength(64)]
        public string NumeroDocumento { get; set; }
        [Column("VALOR_DOCUMENTO", TypeName = "DECIMAL(18, 4)")]
        public decimal ValorDocumento { get; set; }
        [Column("VALOR_COTACAO", TypeName = "DECIMAL(18, 12)")]
        public decimal ValorCotacao { get; set; }
        [Column("VALOR_TOTAL", TypeName = "DECIMAL(18, 12)")]
        public decimal ValorTotal { get; set; }
        [Column("NUMERO_PARCELA")]
        public int NumeroParcela { get; set; }
        [Column("TOTAL_PARCELAS")]
        public int TotalParcelas { get; set; }
        [Column("HISTORICO")]
        [StringLength(512)]
        public string Historico { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
        [Column("NOTAFISCAL_ID")]
        public long? NotafiscalId { get; set; }
        [Column("CTE_ID")]
        public long? CteId { get; set; }
    }
}
