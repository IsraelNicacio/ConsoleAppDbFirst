using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_EVENTO                     ")]
    public partial class CteEvento
    {
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("TPEVENTO")]
        public int Tpevento { get; set; }
        [Column("NSEQEVENTO")]
        public int Nseqevento { get; set; }
        [Required]
        [Column("NPROTAUTORIZACAO")]
        [StringLength(15)]
        public string Nprotautorizacao { get; set; }
        [Column("DHREGEVENTO")]
        public DateTime Dhregevento { get; set; }
        [Required]
        [Column("EVTCTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Evtcte { get; set; }
        [Required]
        [Column("RETEVTCTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Retevtcte { get; set; }
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
