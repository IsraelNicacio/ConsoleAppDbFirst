using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_ITEM                 ")]
    public partial class PdvVendaItem
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("CODIGO")]
        [StringLength(60)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(120)]
        public string Descricao { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
        [Column("VALOR_UNITARIO", TypeName = "DECIMAL(18, 4)")]
        public decimal ValorUnitario { get; set; }
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
