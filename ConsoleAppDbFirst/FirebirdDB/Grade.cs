using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("GRADE                          ")]
    public partial class Grade
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("EIXO_X_ID")]
        public int? EixoXId { get; set; }
        [Column("EIXO_Y_ID")]
        public int? EixoYId { get; set; }
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
