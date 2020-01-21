using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Contribuinte", Schema = "Cadastro")]
    public partial class Contribuinte
    {
        public long Id { get; set; }
        public DateTime? Data { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Contribuinte")]
        public virtual Pessoa IdNavigation { get; set; }
    }
}
