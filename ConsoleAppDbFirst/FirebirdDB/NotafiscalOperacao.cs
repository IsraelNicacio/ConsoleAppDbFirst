using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_OPERACAO            ")]
    public partial class NotafiscalOperacao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("MODELO")]
        [StringLength(2)]
        public string Modelo { get; set; }
        [Column("FINALIDADE_EMISSAO")]
        public short FinalidadeEmissao { get; set; }
        [Column("TIPO_OPERACAO")]
        public short TipoOperacao { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
        [Column("NATUREZA")]
        [StringLength(60)]
        public string Natureza { get; set; }
        [Column("INDICADOR_IBPT")]
        public short IndicadorIbpt { get; set; }
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
