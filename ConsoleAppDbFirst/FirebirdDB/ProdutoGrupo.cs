using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_GRUPO                  ")]
    public partial class ProdutoGrupo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PARENT_ID")]
        public int? ParentId { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
