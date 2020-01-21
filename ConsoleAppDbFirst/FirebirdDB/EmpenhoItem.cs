using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("EMPENHO_ITEM                   ")]
    public partial class EmpenhoItem
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("EMPENHO")]
        [StringLength(32)]
        public string Empenho { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(15, 4)")]
        public decimal Quantidade { get; set; }
        [Column("VALOR_UNITARIO", TypeName = "DECIMAL(18, 3)")]
        public decimal ValorUnitario { get; set; }
        [Column("TOTAL", TypeName = "DECIMAL(14, 2)")]
        public decimal Total { get; set; }
        [Column("DOCUMENTO")]
        [StringLength(1024)]
        public string Documento { get; set; }
        [Column("TAG")]
        public int Tag { get; set; }
    }
}
