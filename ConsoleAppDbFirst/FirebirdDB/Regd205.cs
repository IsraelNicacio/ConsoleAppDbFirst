using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD205                        ")]
    public partial class Regd205
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("ALIQ_COFINS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqCofins { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
