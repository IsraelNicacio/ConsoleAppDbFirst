using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("E2                             ")]
    public partial class E2
    {
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Column("CODIGO_PRODUTO")]
        [StringLength(60)]
        public string CodigoProduto { get; set; }
        [Required]
        [Column("DESCRICAO_PRODUTO")]
        [StringLength(120)]
        public string DescricaoProduto { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(9, 3)")]
        public decimal Quantidade { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
