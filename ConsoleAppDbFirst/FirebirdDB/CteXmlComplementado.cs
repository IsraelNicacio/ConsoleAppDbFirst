using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_COMPLEMENTADO          ")]
    public partial class CteXmlComplementado
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CHAVE")]
        [StringLength(44)]
        public string Chave { get; set; }
    }
}
