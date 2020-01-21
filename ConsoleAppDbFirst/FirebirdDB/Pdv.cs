using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV                            ")]
    public partial class Pdv
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("MAQUINA")]
        [StringLength(32)]
        public string Maquina { get; set; }
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
    }
}
