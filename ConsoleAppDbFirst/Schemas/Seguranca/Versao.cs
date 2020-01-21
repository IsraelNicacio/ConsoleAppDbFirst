using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Versao", Schema = "Seguranca")]
    public partial class Versao
    {
        public int Id { get; set; }
        [Required]
        [StringLength(1024)]
        public string Descricao { get; set; }
    }
}
