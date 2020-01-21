using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("SEGURO_CARGA                   ")]
    public partial class SeguroCarga
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("RESPSEG")]
        public short Respseg { get; set; }
        [Column("CPFCNPJ")]
        [StringLength(14)]
        public string Cpfcnpj { get; set; }
        [Column("NAPOL")]
        [StringLength(20)]
        public string Napol { get; set; }
        [Column("XSEG")]
        [StringLength(30)]
        public string Xseg { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
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
