using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_REFECF          ")]
    public partial class NotafiscalXmlRefecf
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("NECF")]
        [StringLength(3)]
        public string Necf { get; set; }
        [Column("NCOO")]
        [StringLength(6)]
        public string Ncoo { get; set; }
    }
}
