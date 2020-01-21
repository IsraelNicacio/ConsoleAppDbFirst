using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Endereco", Schema = "Cadastro")]
    public partial class Endereco
    {
        public long Id { get; set; }
        public short Tipo { get; set; }
        [Required]
        [StringLength(125)]
        public string Logradouro { get; set; }
        [Required]
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(60)]
        public string Complemento { get; set; }
        [Required]
        [StringLength(60)]
        public string Bairro { get; set; }
        [StringLength(8)]
        public string Cep { get; set; }
        [Required]
        [StringLength(7)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string Estado { get; set; }
        [Required]
        [StringLength(5)]
        public string Pais { get; set; }

        [ForeignKey("Id")]
        [InverseProperty("Endereco")]
        public virtual Pessoa IdNavigation { get; set; }
    }
}
