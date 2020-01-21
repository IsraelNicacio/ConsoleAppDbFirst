using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_NUMERACAO           ")]
    public partial class NotafiscalNumeracao
    {
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NNF")]
        public int Nnf { get; set; }
    }
}
