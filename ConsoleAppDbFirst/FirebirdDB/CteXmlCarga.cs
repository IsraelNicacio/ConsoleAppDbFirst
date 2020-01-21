using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_CARGA                  ")]
    public partial class CteXmlCarga
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("VCARGA", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vcarga { get; set; }
        [Column("PROPRED")]
        [StringLength(60)]
        public string Propred { get; set; }
        [Column("XOUTCAT")]
        [StringLength(30)]
        public string Xoutcat { get; set; }
        [Column("VCARGAAVERB", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vcargaaverb { get; set; }
    }
}
