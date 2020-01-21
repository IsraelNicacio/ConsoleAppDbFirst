using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_RETTRIB         ")]
    public partial class NotafiscalXmlRettrib
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("VRETPIS", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vretpis { get; set; }
        [Column("VRETCOFINS", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vretcofins { get; set; }
        [Column("VRETCSLL", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vretcsll { get; set; }
        [Column("VBCIRRF", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vbcirrf { get; set; }
        [Column("VIRRF", TypeName = "DECIMAL(15, 2)")]
        public decimal? Virrf { get; set; }
        [Column("VBCRETPREV", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vbcretprev { get; set; }
        [Column("VRETPREV", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vretprev { get; set; }
    }
}
