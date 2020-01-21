using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("COMPOSICAO                     ")]
    public partial class Composicao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("CPROD_REF")]
        [StringLength(60)]
        public string CprodRef { get; set; }
        [Required]
        [Column("CPROD_COMPOSTO")]
        [StringLength(60)]
        public string CprodComposto { get; set; }
        [Column("FATOR_CONVERSAO", TypeName = "DECIMAL(18, 6)")]
        public decimal FatorConversao { get; set; }
        [Column("PERCENTUAL_PERDA", TypeName = "DECIMAL(11, 4)")]
        public decimal? PercentualPerda { get; set; }
    }
}
