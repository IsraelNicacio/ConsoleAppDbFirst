using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PEDIDO_ITEM_GRADE              ")]
    public partial class PedidoItemGrade
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PEDIDO_ID")]
        public long PedidoId { get; set; }
        [Column("ITEM_PEDIDO_ID")]
        public long ItemPedidoId { get; set; }
        [Column("X_GRADE_EIXO_ITEM_ID")]
        public int XGradeEixoItemId { get; set; }
        [Column("Y_GRADE_EIXO_ITEM_ID")]
        public int YGradeEixoItemId { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
    }
}
