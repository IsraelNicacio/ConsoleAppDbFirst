using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_VEICTRACAO            ")]
    public partial class MdfeXmlVeictracao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PLACA")]
        [StringLength(7)]
        public string Placa { get; set; }
        [Column("CINT")]
        [StringLength(10)]
        public string Cint { get; set; }
        [Column("RENAVAM")]
        [StringLength(11)]
        public string Renavam { get; set; }
    }
}
