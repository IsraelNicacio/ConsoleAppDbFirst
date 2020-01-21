using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("AUX_REGC120                    ")]
    public partial class AuxRegc120
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("COD_DOC_IMP", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string CodDocImp { get; set; }
        [Column("NUM_DOC_IMP")]
        [StringLength(10)]
        public string NumDocImp { get; set; }
        [Column("PIS_IMP", TypeName = "DECIMAL(18, 2)")]
        public decimal? PisImp { get; set; }
        [Column("COFINS_IMP", TypeName = "DECIMAL(18, 2)")]
        public decimal? CofinsImp { get; set; }
        [Column("NUM_ACDRAW")]
        [StringLength(20)]
        public string NumAcdraw { get; set; }
    }
}
