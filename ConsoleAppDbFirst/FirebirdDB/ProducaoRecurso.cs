using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUCAO_RECURSO               ")]
    public partial class ProducaoRecurso
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("CLASSIFICACAO_ID")]
        public long ClassificacaoId { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(128)]
        public string Descricao { get; set; }
        [Column("QUANTIDADE", TypeName = "DECIMAL(18, 3)")]
        public decimal Quantidade { get; set; }
        [Required]
        [Column("UNIDADE")]
        [StringLength(6)]
        public string Unidade { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 3)")]
        public decimal Valor { get; set; }
    }
}
