using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC141                        ")]
    public partial class Regc141
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_PARC")]
        public int NumParc { get; set; }
        [Column("DT_VCTO")]
        public DateTime DtVcto { get; set; }
        [Column("VL_PARC", TypeName = "DECIMAL(18, 2)")]
        public decimal VlParc { get; set; }
    }
}
