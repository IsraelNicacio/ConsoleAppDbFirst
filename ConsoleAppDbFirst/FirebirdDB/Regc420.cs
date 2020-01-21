using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC420                        ")]
    public partial class Regc420
    {
        [Column("REGC400_ID")]
        public int Regc400Id { get; set; }
        [Column("REGC405_ID")]
        public int Regc405Id { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("COD_TOT_PAR")]
        [StringLength(7)]
        public string CodTotPar { get; set; }
        [Column("VLR_ACUM_TOT", TypeName = "DECIMAL(18, 2)")]
        public decimal VlrAcumTot { get; set; }
        [Column("NR_TOT")]
        public int? NrTot { get; set; }
        [Column("DESCR_NR_TOT")]
        [StringLength(512)]
        public string DescrNrTot { get; set; }
    }
}
