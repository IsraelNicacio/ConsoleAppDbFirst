using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUCAO_PROCESSO              ")]
    public partial class ProducaoProcesso
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ITEM_PEDIDO_ID")]
        public long? ItemPedidoId { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
        [Column("CODIGO")]
        [StringLength(60)]
        public string Codigo { get; set; }
        [Column("DATA_INICIAL")]
        public DateTime DataInicial { get; set; }
        [Column("DATA_FINAL")]
        public DateTime? DataFinal { get; set; }
        [Required]
        [Column("PRODUTO_CODIGO")]
        [StringLength(60)]
        public string ProdutoCodigo { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("QTDE_PREVISTA", TypeName = "DECIMAL(18, 3)")]
        public decimal? QtdePrevista { get; set; }
        [Column("QTDE_PRODUZIDA", TypeName = "DECIMAL(18, 3)")]
        public decimal? QtdeProduzida { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 3)")]
        public decimal Valor { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
        [Column("OBSERVACAO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Observacao { get; set; }
        [Column("ANEXO")]
        [StringLength(2048)]
        public string Anexo { get; set; }
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
