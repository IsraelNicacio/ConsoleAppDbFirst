using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MOEDA                          ")]
    public partial class Moeda
    {
        [Column("SIGLA")]
        [StringLength(6)]
        public string Sigla { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(120)]
        public string Descricao { get; set; }
    }
}
