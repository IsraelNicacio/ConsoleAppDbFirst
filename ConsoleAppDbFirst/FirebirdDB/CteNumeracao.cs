using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_NUMERACAO                  ")]
    public partial class CteNumeracao
    {
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NCT")]
        public int Nct { get; set; }
    }
}
