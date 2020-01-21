using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGRA_TRIBUTARIA_ICMS_ALIQUOTA ")]
    public partial class RegraTributariaIcmsAliquota
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("TIPO")]
        public short Tipo { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("ALIQUOTA", TypeName = "DECIMAL(7, 4)")]
        public decimal? Aliquota { get; set; }
    }
}
