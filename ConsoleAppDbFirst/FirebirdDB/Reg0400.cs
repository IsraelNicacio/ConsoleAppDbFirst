using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG0400                        ")]
    public partial class Reg0400
    {
        [Column("COD_NAT")]
        public int CodNat { get; set; }
        [Required]
        [Column("DESCR_NAT", TypeName = "BLOB SUB_TYPE TEXT")]
        public string DescrNat { get; set; }
    }
}
