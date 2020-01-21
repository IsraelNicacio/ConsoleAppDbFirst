using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_PIS                    ")]
    public partial class ProdutoPis
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("XML_PIS", TypeName = "BLOB SUB_TYPE TEXT")]
        public string XmlPis { get; set; }
        [Column("XML_PISST", TypeName = "BLOB SUB_TYPE TEXT")]
        public string XmlPisst { get; set; }
    }
}
