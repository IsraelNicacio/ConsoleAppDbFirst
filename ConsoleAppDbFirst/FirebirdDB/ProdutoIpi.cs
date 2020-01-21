using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_IPI                    ")]
    public partial class ProdutoIpi
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CNPJPROD")]
        [StringLength(14)]
        public string Cnpjprod { get; set; }
        [Column("CSELO")]
        [StringLength(60)]
        public string Cselo { get; set; }
        [Column("QSELO")]
        [StringLength(12)]
        public string Qselo { get; set; }
        [Column("CENQ")]
        [StringLength(3)]
        public string Cenq { get; set; }
    }
}
