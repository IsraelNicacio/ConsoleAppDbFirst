using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUCAO_PROCESSO_GRADE        ")]
    public partial class ProducaoProcessoGrade
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("X_GRADE_EIXO_ITEM_ID")]
        public int XGradeEixoItemId { get; set; }
        [Column("Y_GRADE_EIXO_ITEM_ID")]
        public int YGradeEixoItemId { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
    }
}
