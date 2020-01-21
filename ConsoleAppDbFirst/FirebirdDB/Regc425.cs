using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC425                        ")]
    public partial class Regc425
    {
        [Column("REGC400_ID")]
        public int Regc400Id { get; set; }
        [Column("REGC405_ID")]
        public int Regc405Id { get; set; }
        [Column("REGC420_ID")]
        public int Regc420Id { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("QTD", TypeName = "DECIMAL(18, 3)")]
        public decimal Qtd { get; set; }
        [Required]
        [Column("UNID")]
        [StringLength(60)]
        public string Unid { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Column("VL_BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlBcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcms { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
    }
}
