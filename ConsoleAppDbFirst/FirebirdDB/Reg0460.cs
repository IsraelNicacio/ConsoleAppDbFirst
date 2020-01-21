using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG0460                        ")]
    public partial class Reg0460
    {
        [Column("COD_OBS")]
        [StringLength(6)]
        public string CodObs { get; set; }
        [Required]
        [Column("TXT", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Txt { get; set; }
    }
}
