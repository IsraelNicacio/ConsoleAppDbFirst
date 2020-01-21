using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG1600                        ")]
    public partial class Reg1600
    {
        [Column("ANO")]
        public int Ano { get; set; }
        [Column("MES")]
        public int Mes { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("TOT_CREDITO", TypeName = "DECIMAL(18, 2)")]
        public decimal TotCredito { get; set; }
        [Column("TOT_DEBITO", TypeName = "DECIMAL(18, 2)")]
        public decimal TotDebito { get; set; }
    }
}
