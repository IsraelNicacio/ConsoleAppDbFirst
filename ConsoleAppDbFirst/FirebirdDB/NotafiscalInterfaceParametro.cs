using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_INTERFACE_PARAMETRO ")]
    public partial class NotafiscalInterfaceParametro
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CHAVE")]
        [StringLength(128)]
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
