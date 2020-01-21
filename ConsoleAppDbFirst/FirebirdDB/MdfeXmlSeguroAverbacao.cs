using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_SEGURO_AVERBACAO      ")]
    public partial class MdfeXmlSeguroAverbacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Required]
        [Column("NAVER")]
        [StringLength(40)]
        public string Naver { get; set; }
    }
}
