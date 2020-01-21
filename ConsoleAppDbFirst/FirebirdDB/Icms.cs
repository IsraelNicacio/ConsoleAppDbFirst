using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ICMS                           ")]
    public partial class Icms
    {
        [Column("UF_ORIGEM")]
        [StringLength(2)]
        public string UfOrigem { get; set; }
        [Column("UF_DESTINO")]
        [StringLength(2)]
        public string UfDestino { get; set; }
        [Column("ALIQUOTA", TypeName = "DECIMAL(6, 2)")]
        public decimal? Aliquota { get; set; }
    }
}
