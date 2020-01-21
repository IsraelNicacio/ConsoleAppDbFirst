using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_EVENTO              ")]
    public partial class NotafiscalEvento
    {
        [Column("CHNFE")]
        [StringLength(44)]
        public string Chnfe { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("TPEVENTO")]
        public int Tpevento { get; set; }
        [Column("NSEQEVENTO")]
        public int Nseqevento { get; set; }
        [Required]
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("DHREGEVENTO")]
        public DateTime Dhregevento { get; set; }
        [Required]
        [Column("EVENTO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Evento { get; set; }
        [Required]
        [Column("RETEVENTO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Retevento { get; set; }
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
