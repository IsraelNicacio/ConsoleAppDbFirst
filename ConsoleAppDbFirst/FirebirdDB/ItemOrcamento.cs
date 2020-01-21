using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ITEM_ORCAMENTO                 ")]
    public partial class ItemOrcamento
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ORCAMENTO_ID")]
        public long OrcamentoId { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(7, 2)")]
        public decimal Quantidade { get; set; }
        [Column("VALOR_UNITARIO", TypeName = "DECIMAL(18, 3)")]
        public decimal ValorUnitario { get; set; }
        [Column("SUBTOTAL", TypeName = "DECIMAL(14, 2)")]
        public decimal Subtotal { get; set; }
        [Column("ACRESCIMO", TypeName = "DECIMAL(8, 2)")]
        public decimal? Acrescimo { get; set; }
        [Column("DESCONTO", TypeName = "DECIMAL(8, 2)")]
        public decimal? Desconto { get; set; }
        [Column("TOTAL", TypeName = "DECIMAL(14, 2)")]
        public decimal Total { get; set; }
        [Column("INFORMACAO_ADICIONAL")]
        [StringLength(500)]
        public string InformacaoAdicional { get; set; }
    }
}
