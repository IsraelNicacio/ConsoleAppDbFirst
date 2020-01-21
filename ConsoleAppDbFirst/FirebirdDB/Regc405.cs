using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC405                        ")]
    public partial class Regc405
    {
        [Column("REGC400_ID")]
        public int Regc400Id { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("CRO")]
        public int Cro { get; set; }
        [Column("CRZ")]
        public int Crz { get; set; }
        [Column("NUM_COO_INI")]
        public int NumCooIni { get; set; }
        [Column("NUM_COO_FIN")]
        public int NumCooFin { get; set; }
        [Column("GT_FIN", TypeName = "DECIMAL(18, 2)")]
        public decimal GtFin { get; set; }
        [Column("VL_BRT", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBrt { get; set; }
    }
}
