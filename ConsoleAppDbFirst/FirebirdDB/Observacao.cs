using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("OBSERVACAO                     ")]
    public partial class Observacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(5000)]
        public string Descricao { get; set; }
    }
}
