using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGK250                        ")]
    public partial class Regk250
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("DT_PROD", TypeName = "DATE")]
        public DateTime DtProd { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("QTD", TypeName = "DECIMAL(18, 3)")]
        public decimal Qtd { get; set; }
    }
}
