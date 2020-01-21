using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC176                        ")]
    public partial class Regc176
    {
        [Column("C176_ID")]
        public int C176Id { get; set; }
        [Column("C170_ID")]
        public int C170Id { get; set; }
        [Column("C170_NUM_ITEM")]
        public int C170NumItem { get; set; }
        [Required]
        [Column("COD_MOD_ULT_E")]
        [StringLength(2)]
        public string CodModUltE { get; set; }
        [Column("NUM_DOC_ULT_E")]
        public int NumDocUltE { get; set; }
        [Column("SER_ULT_E")]
        [StringLength(3)]
        public string SerUltE { get; set; }
        [Column("DT_ULT_E")]
        public DateTime DtUltE { get; set; }
        [Required]
        [Column("COD_PART_ULT_E")]
        [StringLength(60)]
        public string CodPartUltE { get; set; }
        [Column("QUANT_ULT_E", TypeName = "DECIMAL(18, 3)")]
        public decimal QuantUltE { get; set; }
        [Column("VL_UNIT_ULT_E", TypeName = "DECIMAL(18, 3)")]
        public decimal VlUnitUltE { get; set; }
        [Column("VL_UNIT_BC_ST", TypeName = "DECIMAL(18, 3)")]
        public decimal VlUnitBcSt { get; set; }
    }
}
