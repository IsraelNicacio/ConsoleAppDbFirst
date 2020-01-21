using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_INFMUNCARREGA         ")]
    public partial class MdfeXmlInfmuncarrega
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CMUNCARREGA")]
        [StringLength(7)]
        public string Cmuncarrega { get; set; }
    }
}
