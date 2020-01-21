using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("FORMA_PAGAMENTO                ")]
    public partial class FormaPagamento
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(60)]
        public string Descricao { get; set; }
    }
}
