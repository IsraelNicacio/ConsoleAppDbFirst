using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC490                        ")]
    public partial class Regc490
    {
        [Column("REGC400_ID")]
        public int Regc400Id { get; set; }
        [Column("REGC405_ID")]
        public int Regc405Id { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CST_ICMS")]
        [StringLength(3)]
        public string CstIcms { get; set; }
        [Required]
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("ALIQ_ICMS", TypeName = "DECIMAL(6, 2)")]
        public decimal? AliqIcms { get; set; }
        [Column("VL_OPR", TypeName = "DECIMAL(18, 2)")]
        public decimal VlOpr { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcms { get; set; }
        [Column("COD_OBS")]
        [StringLength(6)]
        public string CodObs { get; set; }
    }
}
