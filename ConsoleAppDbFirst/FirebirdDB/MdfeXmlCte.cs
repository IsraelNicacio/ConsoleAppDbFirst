using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_CTE                   ")]
    public partial class MdfeXmlCte
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CMUNDESCARGA")]
        [StringLength(7)]
        public string Cmundescarga { get; set; }
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("INDREENTREGA")]
        public short? Indreentrega { get; set; }
    }
}
