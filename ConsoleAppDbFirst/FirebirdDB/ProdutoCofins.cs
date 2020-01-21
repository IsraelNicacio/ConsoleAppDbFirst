using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO_COFINS                 ")]
    public partial class ProdutoCofins
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("XML_COFINS", TypeName = "BLOB SUB_TYPE TEXT")]
        public string XmlCofins { get; set; }
        [Column("XML_COFINSST", TypeName = "BLOB SUB_TYPE TEXT")]
        public string XmlCofinsst { get; set; }
    }
}
