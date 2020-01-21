using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("BANCO                          ")]
    public partial class Banco
    {
        [Column("NUM_BANCO")]
        [StringLength(6)]
        public string NumBanco { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(64)]
        public string Descricao { get; set; }
    }
}
