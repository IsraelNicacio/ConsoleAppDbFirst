using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_SUPRIMENTO                 ")]
    public partial class PdvSuprimento
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("OPERADOR")]
        public long Operador { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal Valor { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(512)]
        public string Observacao { get; set; }
    }
}
