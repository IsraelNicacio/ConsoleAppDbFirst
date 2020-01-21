using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_COMPRA          ")]
    public partial class NotafiscalXmlCompra
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("XNEMP")]
        [StringLength(22)]
        public string Xnemp { get; set; }
        [Column("XPED")]
        [StringLength(60)]
        public string Xped { get; set; }
        [Column("XCONT")]
        [StringLength(60)]
        public string Xcont { get; set; }
    }
}
