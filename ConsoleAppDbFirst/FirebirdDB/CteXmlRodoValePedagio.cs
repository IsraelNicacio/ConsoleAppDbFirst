using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_RODO_VALE_PEDAGIO      ")]
    public partial class CteXmlRodoValePedagio
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("CNPJFORN")]
        [StringLength(14)]
        public string Cnpjforn { get; set; }
        [Column("NCOMPRA")]
        [StringLength(20)]
        public string Ncompra { get; set; }
        [Column("CNPJPG")]
        [StringLength(14)]
        public string Cnpjpg { get; set; }
        [Column("VVALEPED", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vvaleped { get; set; }
    }
}
