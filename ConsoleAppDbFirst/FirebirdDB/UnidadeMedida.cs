using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("UNIDADE_MEDIDA                 ")]
    public partial class UnidadeMedida
    {
        [Column("UNID")]
        [StringLength(6)]
        public string Unid { get; set; }
        [Required]
        [Column("DESCR")]
        [StringLength(1024)]
        public string Descr { get; set; }
    }
}
