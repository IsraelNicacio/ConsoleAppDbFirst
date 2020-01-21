using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC110                        ")]
    public partial class Regc110
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("COD_INF")]
        [StringLength(6)]
        public string CodInf { get; set; }
        [Column("TXT_COMPL", TypeName = "BLOB SUB_TYPE TEXT")]
        public string TxtCompl { get; set; }
    }
}
