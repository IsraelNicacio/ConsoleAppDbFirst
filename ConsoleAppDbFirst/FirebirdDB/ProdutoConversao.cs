using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_CONVERSAO              ")]
    public partial class ProdutoConversao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("UNID_CONV")]
        [StringLength(6)]
        public string UnidConv { get; set; }
        [Column("FAT_CONV", TypeName = "DECIMAL(18, 6)")]
        public decimal FatConv { get; set; }
    }
}
