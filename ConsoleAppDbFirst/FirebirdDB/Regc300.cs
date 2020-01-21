using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC300                        ")]
    public partial class Regc300
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Required]
        [Column("SER")]
        [StringLength(4)]
        public string Ser { get; set; }
        [Column("SUB")]
        [StringLength(3)]
        public string Sub { get; set; }
        [Column("NUM_DOC_INI")]
        public int NumDocIni { get; set; }
        [Column("NUM_DOC_FIN")]
        public int NumDocFin { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
