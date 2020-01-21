using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_RODO_MOTORISTA         ")]
    public partial class CteXmlRodoMotorista
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
    }
}
