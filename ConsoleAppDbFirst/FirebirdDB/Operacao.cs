using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("OPERACAO                       ")]
    public partial class Operacao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("FUNCIONALIDADE_ID")]
        public int FuncionalidadeId { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
