using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Email", Schema = "Cadastro")]
    public partial class Email
    {
        public long Id { get; set; }
        public short Ordem { get; set; }
        [StringLength(128)]
        public string Endereco { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Email")]
        public virtual Pessoa IdNavigation { get; set; }
    }
}
