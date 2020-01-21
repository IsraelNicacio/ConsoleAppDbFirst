using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CFOP                           ")]
    public partial class Cfop
    {
        [Column("CCFOP")]
        [StringLength(4)]
        public string Ccfop { get; set; }
        [Required]
        [Column("XCFOP")]
        [StringLength(1024)]
        public string Xcfop { get; set; }
        [Column("ESTOQUE_MOVIMENTACAO")]
        public short? EstoqueMovimentacao { get; set; }
        [Column("SPED_PIS_COFINS")]
        public short? SpedPisCofins { get; set; }
    }
}
