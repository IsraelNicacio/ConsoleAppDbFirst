using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONFIGURACAO_USUARIO           ")]
    public partial class ConfiguracaoUsuario
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("USUARIO_ID")]
        public int UsuarioId { get; set; }
        [Required]
        [Column("CHAVE")]
        [StringLength(64)]
        public string Chave { get; set; }
        [Column("GRUPO")]
        [StringLength(512)]
        public string Grupo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(512)]
        public string Observacao { get; set; }
        [Column("VALOR", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Valor { get; set; }
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
