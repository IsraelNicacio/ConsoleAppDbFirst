using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_OPERACAO               ")]
    public partial class EstoqueOperacao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PARENT_ID")]
        public int? ParentId { get; set; }
        [Column("INDICE")]
        public int? Indice { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
        [Column("PADRAO")]
        public short Padrao { get; set; }
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
