using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO_VALOR     ")]
    public partial class EstoqueMovimentacaoValor
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(2048)]
        public string Descricao { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 3)")]
        public decimal Valor { get; set; }
    }
}
