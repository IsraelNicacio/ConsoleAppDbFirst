using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("USUARIO                        ")]
    public partial class Usuario
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("SENHA")]
        [StringLength(256)]
        public string Senha { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(256)]
        public string Nome { get; set; }
        [Column("PERGUNTA_RECUPERAR_SENHA")]
        [StringLength(256)]
        public string PerguntaRecuperarSenha { get; set; }
        [Column("RESPOSTA_RECUPERAR_SENHA")]
        [StringLength(256)]
        public string RespostaRecuperarSenha { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(256)]
        public string Email { get; set; }
        [Column("ATIVO")]
        public int Ativo { get; set; }
        [Column("BLOQUEADO")]
        public int Bloqueado { get; set; }
        [Column("LOGADO")]
        public int Logado { get; set; }
        [Column("DATA_CRIACAO")]
        public DateTime DataCriacao { get; set; }
        [Column("DATA_ULTIMA_ATIVIDADE")]
        public DateTime? DataUltimaAtividade { get; set; }
        [Column("DATA_ULTIMO_LOGIN")]
        public DateTime? DataUltimoLogin { get; set; }
        [Column("DATA_ULTIMO_BLOQUEIO")]
        public DateTime? DataUltimoBloqueio { get; set; }
        [Column("DATA_ULTIMA_ALTERACAO_SENHA")]
        public DateTime DataUltimaAlteracaoSenha { get; set; }
        [Column("QTDE_SENHA_INCORRETA")]
        public int? QtdeSenhaIncorreta { get; set; }
        [Column("HORA_INICIAL_SENHA_INCORRETA")]
        public DateTime? HoraInicialSenhaIncorreta { get; set; }
        [Column("GRUPO_USUARIO_ID")]
        public int GrupoUsuarioId { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
    }
}
