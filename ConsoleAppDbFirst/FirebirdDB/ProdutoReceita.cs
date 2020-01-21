using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_RECEITA                ")]
    public partial class ProdutoReceita
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("NAT_REC_PIS")]
        [StringLength(3)]
        public string NatRecPis { get; set; }
        [Column("ALIQ_PIS_POR", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqPisPor { get; set; }
        [Column("ALIQ_PIS_REAIS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqPisReais { get; set; }
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("NAT_REC_COFINS")]
        [StringLength(3)]
        public string NatRecCofins { get; set; }
        [Column("ALIQ_COFINS_POR", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqCofinsPor { get; set; }
        [Column("ALIQ_COFINS_REAIS", TypeName = "DECIMAL(18, 4)")]
        public decimal? AliqCofinsReais { get; set; }
    }
}
