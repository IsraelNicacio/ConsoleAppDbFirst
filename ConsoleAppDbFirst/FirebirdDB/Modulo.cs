using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MODULO                         ")]
    public partial class Modulo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
