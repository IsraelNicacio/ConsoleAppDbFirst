using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PAGADORA_BENEFICIARIA          ")]
    public partial class PagadoraBeneficiaria
    {
        [Column("ID")]
        public long Id { get; set; }
    }
}
