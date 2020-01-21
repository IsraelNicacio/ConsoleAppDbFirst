using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_SPED                   ")]
    public partial class ProdutoSped
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CST_ICMS")]
        [StringLength(4)]
        public string CstIcms { get; set; }
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
