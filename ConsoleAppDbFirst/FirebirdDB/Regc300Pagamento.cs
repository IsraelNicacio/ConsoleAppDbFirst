using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC300_PAGAMENTO              ")]
    public partial class Regc300Pagamento
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("MEIO_PAGAMENTO")]
        [StringLength(15)]
        public string MeioPagamento { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal Valor { get; set; }
    }
}
