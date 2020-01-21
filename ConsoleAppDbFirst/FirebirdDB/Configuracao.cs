using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONFIGURACAO                   ")]
    public partial class Configuracao
    {
        [Column("CHAVE")]
        [StringLength(64)]
        public string Chave { get; set; }
        [Column("GRUPO")]
        [StringLength(512)]
        public string Grupo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(512)]
        public string Descricao { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(512)]
        public string Observacao { get; set; }
        [Column("VALOR", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Valor { get; set; }
    }
}
