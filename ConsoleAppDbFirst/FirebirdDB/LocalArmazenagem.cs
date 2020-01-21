using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("LOCAL_ARMAZENAGEM              ")]
    public partial class LocalArmazenagem
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO_LOCAL")]
        [StringLength(512)]
        public string DescricaoLocal { get; set; }
    }
}
