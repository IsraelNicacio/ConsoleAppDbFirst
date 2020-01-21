using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_INFADIC_OBSCONT ")]
    public partial class NotafiscalXmlInfadicObscont
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("XCAMPO")]
        [StringLength(20)]
        public string Xcampo { get; set; }
        [Required]
        [Column("XTEXTO")]
        [StringLength(60)]
        public string Xtexto { get; set; }
    }
}
