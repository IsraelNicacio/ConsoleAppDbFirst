using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CARGO                          ")]
    public partial class Cargo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        [StringLength(80)]
        public string Descricao { get; set; }
    }
}
