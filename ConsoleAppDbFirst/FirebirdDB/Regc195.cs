using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC195                        ")]
    public partial class Regc195
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("COD_OBS")]
        [StringLength(6)]
        public string CodObs { get; set; }
        [Column("TXT_COMPL", TypeName = "BLOB SUB_TYPE TEXT")]
        public string TxtCompl { get; set; }
    }
}
