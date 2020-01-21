using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("FUNCIONALIDADE                 ")]
    public partial class Funcionalidade
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("MODULO_ID")]
        public int ModuloId { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
