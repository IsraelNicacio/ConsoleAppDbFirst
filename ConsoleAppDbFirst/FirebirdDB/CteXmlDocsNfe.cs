using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_DOCS_NFE               ")]
    public partial class CteXmlDocsNfe
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("CHAVE")]
        [StringLength(44)]
        public string Chave { get; set; }
        [Column("PIN")]
        [StringLength(9)]
        public string Pin { get; set; }
        [Column("DPREV", TypeName = "DATE")]
        public DateTime? Dprev { get; set; }
    }
}
