using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Permissao", Schema = "Seguranca")]
    public partial class Permissao
    {
        public int GrupoUsuarioId { get; set; }
        public int OperacaoId { get; set; }
        public int FuncionalidadeId { get; set; }

        [ForeignKey("GrupoUsuarioId")]
        [InverseProperty("Permissao")]
        public virtual GrupoUsuario GrupoUsuario { get; set; }
        [ForeignKey("OperacaoId,FuncionalidadeId")]
        [InverseProperty("Permissao")]
        public virtual Operacao Operacao { get; set; }
    }
}
