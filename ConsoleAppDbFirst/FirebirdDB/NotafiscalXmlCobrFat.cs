using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_COBR_FAT        ")]
    public partial class NotafiscalXmlCobrFat
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NFAT")]
        [StringLength(60)]
        public string Nfat { get; set; }
        [Column("VORIG", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vorig { get; set; }
        [Column("VDESC", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdesc { get; set; }
        [Column("VLIQ", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vliq { get; set; }
    }
}
