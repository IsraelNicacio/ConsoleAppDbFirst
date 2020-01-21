using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_SEGURO                 ")]
    public partial class CteXmlSeguro
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("RESPSEG")]
        [StringLength(2)]
        public string Respseg { get; set; }
        [Column("XSEG")]
        [StringLength(30)]
        public string Xseg { get; set; }
        [Column("NAPOL")]
        [StringLength(20)]
        public string Napol { get; set; }
        [Column("NAVER")]
        [StringLength(20)]
        public string Naver { get; set; }
        [Column("VCARGA", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vcarga { get; set; }
    }
}
