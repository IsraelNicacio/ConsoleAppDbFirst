using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO           ")]
    public partial class EstoqueMovimentacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("MOVIMENTACAO_REFERENCIA_ID")]
        public long? MovimentacaoReferenciaId { get; set; }
        [Column("PRODUCAO_PROCESSO_ID")]
        public long? ProducaoProcessoId { get; set; }
        [Column("RESERVA_ID")]
        public long? ReservaId { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
        [Column("PDV_VENDA_ID")]
        public long? PdvVendaId { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("OPERACAO_ID")]
        public int OperacaoId { get; set; }
        [Column("PROPRIEDADE_INDICADOR")]
        public short PropriedadeIndicador { get; set; }
        [Column("PROPRIEDADE_PESSOA_ID")]
        public long? PropriedadePessoaId { get; set; }
        [Required]
        [Column("PRODUTO_CODIGO")]
        [StringLength(60)]
        public string ProdutoCodigo { get; set; }
        [Column("PRODUTO_SUBSTITUIDO_CODIGO")]
        [StringLength(60)]
        public string ProdutoSubstituidoCodigo { get; set; }
        [Column("PRODUTO_LOTE_ID")]
        public long? ProdutoLoteId { get; set; }
        [Column("LOCAL_ID")]
        public int LocalId { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
        [Column("VALOR_UNITARIO", TypeName = "DECIMAL(18, 10)")]
        public decimal ValorUnitario { get; set; }
        [Column("VALOR_TOTAL", TypeName = "DECIMAL(18, 10)")]
        public decimal ValorTotal { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(2048)]
        public string Observacao { get; set; }
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
