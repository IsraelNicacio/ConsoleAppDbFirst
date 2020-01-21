using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ANALISTA_IBPT_CFOP             ")]
    public partial class AnalistaIbptCfop
    {
        [Column("CCFOP")]
        [StringLength(4)]
        public string Ccfop { get; set; }
    }
}
