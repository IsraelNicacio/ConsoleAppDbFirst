using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_ITEM_GRADE           ")]
    public partial class PdvVendaItemGrade
    {
        [Column("PDV_VENDA_ITEM_ID")]
        public long PdvVendaItemId { get; set; }
        [Column("PDV_VENDA_ITEM_NUMERO")]
        public short PdvVendaItemNumero { get; set; }
        [Column("PDV_VENDA_ITEM_GRADE_NUMERO")]
        public short PdvVendaItemGradeNumero { get; set; }
        [Column("X_GRADE_EIXO_ITEM_ID")]
        public int XGradeEixoItemId { get; set; }
        [Column("Y_GRADE_EIXO_ITEM_ID")]
        public int YGradeEixoItemId { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
    }
}
