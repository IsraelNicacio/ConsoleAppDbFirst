using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Telefone", Schema = "Cadastro")]
    public partial class Telefone
    {
        public long Id { get; set; }
        public short Tipo { get; set; }
        [Required]
        [StringLength(11)]
        public string Numero { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Telefone")]
        public virtual Pessoa IdNavigation { get; set; }
    }
}
