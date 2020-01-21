using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_CANCELAMENTO         ")]
    public partial class PdvVendaCancelamento
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("OPERADOR")]
        public long Operador { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("JUSTIFICATIVA")]
        [StringLength(512)]
        public string Justificativa { get; set; }
    }
}
