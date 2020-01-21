using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Pessoa", Schema = "Cadastro")]
    public partial class Pessoa
    {
        public Pessoa()
        {
            Email = new HashSet<Email>();
            Endereco = new HashSet<Endereco>();
            Telefone = new HashSet<Telefone>();
        }

        public long Id { get; set; }
        [StringLength(14)]
        public string CpfCnpj { get; set; }
        [StringLength(15)]
        public string InscricaoEstadual { get; set; }
        [StringLength(15)]
        public string InscricaoMunicipal { get; set; }
        [Required]
        [StringLength(115)]
        public string Nome { get; set; }
        [StringLength(16)]
        public string CodigoAuxiliar { get; set; }
        [StringLength(256)]
        public string IdentificacaoAuxiliar { get; set; }
        public int IssRetido { get; set; }
        [StringLength(1024)]
        public string Observacao { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual Contribuinte Contribuinte { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Email> Email { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Endereco> Endereco { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Telefone> Telefone { get; set; }
    }
}
