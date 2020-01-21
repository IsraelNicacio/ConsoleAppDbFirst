using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_DOCS_OUTROS            ")]
    public partial class CteXmlDocsOutros
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("TPDOC")]
        [StringLength(2)]
        public string Tpdoc { get; set; }
        [Column("DESCOUTROS")]
        [StringLength(100)]
        public string Descoutros { get; set; }
        [Column("NDOC")]
        [StringLength(20)]
        public string Ndoc { get; set; }
        [Column("DEMI", TypeName = "DATE")]
        public DateTime? Demi { get; set; }
        [Column("VDOCFISC", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vdocfisc { get; set; }
        [Column("DPREV", TypeName = "DATE")]
        public DateTime? Dprev { get; set; }
    }
}
