using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("EQUIVALENCIA_PRODUTO           ")]
    public partial class EquivalenciaProduto
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("CPROD_FORNECEDOR")]
        [StringLength(60)]
        public string CprodFornecedor { get; set; }
    }
}
