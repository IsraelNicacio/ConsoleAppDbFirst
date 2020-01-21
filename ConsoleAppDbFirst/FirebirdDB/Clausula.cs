using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CLAUSULA                       ")]
    public partial class Clausula
    {
        [Column("PROPOSTA_ID")]
        public long PropostaId { get; set; }
        [Column("NUMERO_CLAUSULA")]
        [StringLength(32)]
        public string NumeroClausula { get; set; }
        [Required]
        [Column("DESCRICAO_CLAUSULA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string DescricaoClausula { get; set; }
        [Column("ORDEM")]
        public int Ordem { get; set; }
    }
}
