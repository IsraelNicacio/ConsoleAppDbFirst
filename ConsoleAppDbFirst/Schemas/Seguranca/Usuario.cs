using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Usuario", Schema = "Seguranca")]
    public partial class Usuario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Senha { get; set; }
        [Required]
        [StringLength(256)]
        public string Nome { get; set; }
        [StringLength(256)]
        public string PerguntaRecuperarSenha { get; set; }
        [StringLength(256)]
        public string RespostaRecuperarSenha { get; set; }
        [Required]
        [StringLength(256)]
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }
        public bool Logado { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAtividade { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
        public DateTime? DataUltimoBloqueio { get; set; }
        public DateTime DataUltimaAlteracaoSenha { get; set; }
        public int? QtdeSenhaIncorreta { get; set; }
        public DateTime? HoraInicialSenhaIncorreta { get; set; }
        public int GrupoUsuarioId { get; set; }

        [ForeignKey("GrupoUsuarioId")]
        [InverseProperty("Usuario")]
        public virtual GrupoUsuario GrupoUsuario { get; set; }
    }
}
