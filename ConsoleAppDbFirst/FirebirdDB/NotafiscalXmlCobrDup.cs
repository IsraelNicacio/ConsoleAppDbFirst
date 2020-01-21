using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_COBR_DUP        ")]
    public partial class NotafiscalXmlCobrDup
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NDUP")]
        [StringLength(60)]
        public string Ndup { get; set; }
        [Column("DVENC", TypeName = "DATE")]
        public DateTime? Dvenc { get; set; }
        [Column("VDUP", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdup { get; set; }
    }
}
