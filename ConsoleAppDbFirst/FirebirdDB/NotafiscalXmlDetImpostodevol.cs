using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_DET_IMPOSTODEVOL")]
    public partial class NotafiscalXmlDetImpostodevol
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NITEM")]
        public int Nitem { get; set; }
        [Column("PDEVOL", TypeName = "DECIMAL(7, 4)")]
        public decimal? Pdevol { get; set; }
        [Column("IPI_VIPIDEVOL", TypeName = "DECIMAL(15, 2)")]
        public decimal? IpiVipidevol { get; set; }
    }
}
