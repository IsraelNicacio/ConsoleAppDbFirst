using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ANALISTA_FORNECEDOR            ")]
    public partial class AnalistaFornecedor
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("CODIGO_PRODUTO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string CodigoProduto { get; set; }
    }
}
