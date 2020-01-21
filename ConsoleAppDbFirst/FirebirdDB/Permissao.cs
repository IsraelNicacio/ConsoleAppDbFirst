using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PERMISSAO                      ")]
    public partial class Permissao
    {
        [Column("OPERACAO_ID")]
        public int OperacaoId { get; set; }
        [Column("FUNCIONALIDADE_ID")]
        public int FuncionalidadeId { get; set; }
        [Column("GRUPOUSUARIO_ID")]
        public int GrupousuarioId { get; set; }
    }
}
