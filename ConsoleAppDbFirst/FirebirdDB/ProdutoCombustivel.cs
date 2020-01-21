using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_COMBUSTIVEL            ")]
    public partial class ProdutoCombustivel
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CPROD_ANP")]
        [StringLength(9)]
        public string CprodAnp { get; set; }
        [Column("DESC_ANP")]
        [StringLength(95)]
        public string DescAnp { get; set; }
        [Column("UF_CONS")]
        [StringLength(4)]
        public string UfCons { get; set; }
        [Column("PERCENTUAL_GLP", TypeName = "DECIMAL(7, 4)")]
        public decimal? PercentualGlp { get; set; }
        [Column("PERCENTUAL_GNN", TypeName = "DECIMAL(7, 4)")]
        public decimal? PercentualGnn { get; set; }
        [Column("PERCENTUAL_GNI", TypeName = "DECIMAL(7, 4)")]
        public decimal? PercentualGni { get; set; }
        [Column("VALOR_PARTIDA", TypeName = "DECIMAL(15, 2)")]
        public decimal? ValorPartida { get; set; }
    }
}
