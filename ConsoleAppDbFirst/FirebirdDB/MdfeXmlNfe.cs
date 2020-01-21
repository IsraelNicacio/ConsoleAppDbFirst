using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_NFE                   ")]
    public partial class MdfeXmlNfe
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CMUNDESCARGA")]
        [StringLength(7)]
        public string Cmundescarga { get; set; }
        [Column("CHNFE")]
        [StringLength(44)]
        public string Chnfe { get; set; }
        [Column("INDREENTREGA")]
        public short? Indreentrega { get; set; }
    }
}
