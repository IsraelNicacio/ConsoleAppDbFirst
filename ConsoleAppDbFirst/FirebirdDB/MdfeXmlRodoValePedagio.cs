using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_RODO_VALE_PEDAGIO     ")]
    public partial class MdfeXmlRodoValePedagio
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("CNPJFORN")]
        [StringLength(14)]
        public string Cnpjforn { get; set; }
        [Column("CPFCNPJPG")]
        [StringLength(14)]
        public string Cpfcnpjpg { get; set; }
        [Column("NCOMPRA")]
        [StringLength(20)]
        public string Ncompra { get; set; }
        [Column("VVALEPED", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vvaleped { get; set; }
    }
}
