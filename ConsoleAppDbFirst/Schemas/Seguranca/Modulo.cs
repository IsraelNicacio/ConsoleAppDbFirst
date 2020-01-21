using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Modulo", Schema = "Seguranca")]
    public partial class Modulo
    {
        public Modulo()
        {
            Funcionalidade = new HashSet<Funcionalidade>();
        }

        public short Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }

        [InverseProperty("Modulo")]
        public virtual ICollection<Funcionalidade> Funcionalidade { get; set; }
    }
}
