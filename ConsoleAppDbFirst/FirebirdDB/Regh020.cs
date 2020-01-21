using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGH020                        ")]
    public partial class Regh020
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CST_ICMS")]
        [StringLength(3)]
        public string CstIcms { get; set; }
        [Column("BC_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal BcIcms { get; set; }
        [Column("VL_ICMS", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcms { get; set; }
    }
}
