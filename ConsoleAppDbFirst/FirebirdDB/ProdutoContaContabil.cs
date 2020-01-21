using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_CONTA_CONTABIL         ")]
    public partial class ProdutoContaContabil
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("COD_CTA_RECEITA")]
        [StringLength(60)]
        public string CodCtaReceita { get; set; }
        [Column("COD_CTA_DESPESA")]
        [StringLength(60)]
        public string CodCtaDespesa { get; set; }
    }
}
