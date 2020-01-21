using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_RESERVA                ")]
    public partial class EstoqueReserva
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PRODUCAO_PROCESSO_ID")]
        public long? ProducaoProcessoId { get; set; }
        [Column("ITEM_PEDIDO_ID")]
        public long? ItemPedidoId { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
        [Column("INTERESSADO_PESSOA_ID")]
        public long? InteressadoPessoaId { get; set; }
        [Column("PROPRIEDADE_INDICADOR")]
        public short PropriedadeIndicador { get; set; }
        [Column("PROPRIEDADE_PESSOA_ID")]
        public long? PropriedadePessoaId { get; set; }
        [Required]
        [Column("PRODUTO_CODIGO")]
        [StringLength(60)]
        public string ProdutoCodigo { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(2048)]
        public string Observacao { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
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
