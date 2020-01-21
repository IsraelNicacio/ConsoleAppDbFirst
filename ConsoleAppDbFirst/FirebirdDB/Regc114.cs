using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC114                        ")]
    public partial class Regc114
    {
        [Column("C110_ID")]
        public int C110Id { get; set; }
        [Column("C110_COD_INF")]
        [StringLength(6)]
        public string C110CodInf { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Column("ECF_FAB")]
        [StringLength(21)]
        public string EcfFab { get; set; }
        [Column("ECF_CX")]
        public int EcfCx { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
    }
}
