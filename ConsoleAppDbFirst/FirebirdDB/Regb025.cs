using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGB025                        ")]
    public partial class Regb025
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUM_ITEM")]
        public int NumItem { get; set; }
        [Column("VL_CONT_P", TypeName = "DECIMAL(18, 2)")]
        public decimal VlContP { get; set; }
        [Column("VL_BC_ISS_P", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcIssP { get; set; }
        [Column("ALIQ_ISS", TypeName = "DECIMAL(6, 2)")]
        public decimal AliqIss { get; set; }
        [Column("VL_ISS_P", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIssP { get; set; }
        [Column("VL_ISNT_ISS_P", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIsntIssP { get; set; }
        [Required]
        [Column("COD_SERV")]
        [StringLength(4)]
        public string CodServ { get; set; }
    }
}
