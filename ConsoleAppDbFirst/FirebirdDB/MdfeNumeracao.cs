using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_NUMERACAO                 ")]
    public partial class MdfeNumeracao
    {
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NMDF")]
        public int Nmdf { get; set; }
    }
}
