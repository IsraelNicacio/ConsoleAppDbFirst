using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_CREDITO                ")]
    public partial class ProdutoCredito
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("NAT_BC_CRED")]
        [StringLength(2)]
        public string NatBcCred { get; set; }
        [Column("IND_ORIG_CRED")]
        [StringLength(1)]
        public string IndOrigCred { get; set; }
    }
}
