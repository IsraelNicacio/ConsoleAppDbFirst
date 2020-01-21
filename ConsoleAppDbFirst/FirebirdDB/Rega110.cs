using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGA110                        ")]
    public partial class Rega110
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
    }
}
