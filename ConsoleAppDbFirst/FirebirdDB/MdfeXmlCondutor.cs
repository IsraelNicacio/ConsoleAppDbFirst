using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_XML_CONDUTOR              ")]
    public partial class MdfeXmlCondutor
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [Column("XNOME")]
        [StringLength(128)]
        public string Xnome { get; set; }
    }
}
