using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_INTERFACE           ")]
    public partial class NotafiscalInterface
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("MODELO")]
        [StringLength(2)]
        public string Modelo { get; set; }
        [Column("INDICE")]
        public short Indice { get; set; }
        [Required]
        [Column("CHAVE")]
        [StringLength(36)]
        public string Chave { get; set; }
        [Required]
        [Column("TITULO")]
        [StringLength(64)]
        public string Titulo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("PARAMETROS", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Parametros { get; set; }
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
