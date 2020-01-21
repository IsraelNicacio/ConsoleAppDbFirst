using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_ANULACAO               ")]
    public partial class CteXmlAnulacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("DEMI", TypeName = "DATE")]
        public DateTime? Demi { get; set; }
    }
}
