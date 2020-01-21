using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGA120                        ")]
    public partial class Rega120
    {
        [Column("ID_A100")]
        public int IdA100 { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("VL_TOT_SERV", TypeName = "DECIMAL(18, 2)")]
        public decimal VlTotServ { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcPis { get; set; }
        [Column("VL_PIS_IMP", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPisImp { get; set; }
        [Column("DT_PAG_PIS")]
        public DateTime? DtPagPis { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcCofins { get; set; }
        [Column("VL_COFINS_IMP", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofinsImp { get; set; }
        [Column("DT_PAG_COFINS")]
        public DateTime? DtPagCofins { get; set; }
        [Required]
        [Column("LOC_EXE_SERV")]
        [StringLength(1)]
        public string LocExeServ { get; set; }
    }
}
