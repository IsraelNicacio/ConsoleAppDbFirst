using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGK255                        ")]
    public partial class Regk255
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("DT_CONS", TypeName = "DATE")]
        public DateTime DtCons { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("QTD", TypeName = "DECIMAL(18, 3)")]
        public decimal Qtd { get; set; }
        [Column("COD_INS_SUBST")]
        [StringLength(60)]
        public string CodInsSubst { get; set; }
    }
}
