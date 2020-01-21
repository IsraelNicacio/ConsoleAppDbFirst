using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("GRUPOUSUARIO                   ")]
    public partial class Grupousuario
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(64)]
        public string Descricao { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
        [Column("ATIVO")]
        public int Ativo { get; set; }
    }
}
