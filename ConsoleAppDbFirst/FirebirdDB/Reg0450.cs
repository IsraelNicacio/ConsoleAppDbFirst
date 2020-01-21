using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG0450                        ")]
    public partial class Reg0450
    {
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
        [Required]
        [Column("TXT", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Txt { get; set; }
    }
}
