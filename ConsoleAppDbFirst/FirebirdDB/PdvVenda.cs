using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA                      ")]
    public partial class PdvVenda
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PONTO_VENDA")]
        public int PontoVenda { get; set; }
        [Column("OPERADOR")]
        public long Operador { get; set; }
        [Column("VENDEDOR")]
        public long Vendedor { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("INDICADOR_PRESENCA")]
        public short IndicadorPresenca { get; set; }
        [Column("SUBTOTAL", TypeName = "DECIMAL(18, 2)")]
        public decimal Subtotal { get; set; }
        [Column("DESCONTO", TypeName = "DECIMAL(18, 2)")]
        public decimal Desconto { get; set; }
        [Column("ACRESCIMO", TypeName = "DECIMAL(18, 2)")]
        public decimal Acrescimo { get; set; }
        [Column("TOTAL", TypeName = "DECIMAL(18, 2)")]
        public decimal Total { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
    }
}
