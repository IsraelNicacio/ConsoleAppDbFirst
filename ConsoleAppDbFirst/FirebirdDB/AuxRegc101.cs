using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("AUX_REGC101                    ")]
    public partial class AuxRegc101
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("VL_FCP_UF_DEST", TypeName = "DECIMAL(18, 2)")]
        public decimal VlFcpUfDest { get; set; }
        [Column("VL_ICMS_UF_DEST", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcmsUfDest { get; set; }
        [Column("VL_ICMS_UF_REM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlIcmsUfRem { get; set; }
    }
}
