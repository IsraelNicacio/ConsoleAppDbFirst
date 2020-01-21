using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_LOTE                   ")]
    public partial class ProdutoLote
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("DATA_HORA_FABRICACAO")]
        public DateTime? DataHoraFabricacao { get; set; }
        [Column("DATA_HORA_VALIDADE")]
        public DateTime? DataHoraValidade { get; set; }
        [Column("ALERTA_DIAS_VALIDADE")]
        public int? AlertaDiasValidade { get; set; }
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
