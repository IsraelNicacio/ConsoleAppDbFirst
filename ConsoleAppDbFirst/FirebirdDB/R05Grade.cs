using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R05_GRADE                      ")]
    public partial class R05Grade
    {
        [Column("NUMERO_FABRICACAO")]
        [StringLength(20)]
        public string NumeroFabricacao { get; set; }
        [Column("CCF")]
        public int Ccf { get; set; }
        [Column("COO")]
        public int Coo { get; set; }
        [Column("NUMERO_ITEM")]
        public int NumeroItem { get; set; }
        [Column("ID")]
        public long Id { get; set; }
        [Column("X_GRADE_EIXO_ITEM_ID")]
        public int XGradeEixoItemId { get; set; }
        [Column("Y_GRADE_EIXO_ITEM_ID")]
        public int YGradeEixoItemId { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(9, 0)")]
        public decimal Quantidade { get; set; }
    }
}
