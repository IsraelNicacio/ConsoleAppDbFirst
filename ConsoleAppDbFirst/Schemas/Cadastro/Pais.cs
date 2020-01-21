using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Pais", Schema = "Cadastro")]
    public partial class Pais
    {
        [Key]
        [StringLength(5)]
        public string Codigo { get; set; }
        [StringLength(128)]
        public string Nome { get; set; }
    }
}
