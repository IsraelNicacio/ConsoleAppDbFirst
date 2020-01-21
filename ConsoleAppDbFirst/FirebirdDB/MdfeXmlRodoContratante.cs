using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_RODO_CONTRATANTE      ")]
    public partial class MdfeXmlRodoContratante
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("CPFCNPJ")]
        [StringLength(14)]
        public string Cpfcnpj { get; set; }
    }
}
