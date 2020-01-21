using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_TRIBUTACAO          ")]
    public partial class NotafiscalTributacao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CODIGO")]
        [StringLength(256)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
        [Column("INDICADOR_PRODUTO_SERVICO")]
        public short IndicadorProdutoServico { get; set; }
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
