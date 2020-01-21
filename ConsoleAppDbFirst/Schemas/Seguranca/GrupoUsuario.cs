using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("GrupoUsuario", Schema = "Seguranca")]
    public partial class GrupoUsuario
    {
        public GrupoUsuario()
        {
            Permissao = new HashSet<Permissao>();
            Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }
        [StringLength(1024)]
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        [InverseProperty("GrupoUsuario")]
        public virtual ICollection<Permissao> Permissao { get; set; }
        [InverseProperty("GrupoUsuario")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
