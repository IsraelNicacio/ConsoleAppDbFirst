using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_SEGURO                ")]
    public partial class MdfeXmlSeguro
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("RESPSEG")]
        public short Respseg { get; set; }
        [Required]
        [Column("CPFCNPJ")]
        [StringLength(14)]
        public string Cpfcnpj { get; set; }
        [Column("NAPOL")]
        [StringLength(20)]
        public string Napol { get; set; }
        [Column("XSEG")]
        [StringLength(30)]
        public string Xseg { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
    }
}
