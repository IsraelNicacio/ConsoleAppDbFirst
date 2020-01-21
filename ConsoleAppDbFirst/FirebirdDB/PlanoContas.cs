using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PLANO_CONTAS                   ")]
    public partial class PlanoContas
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("FATHER_ID")]
        public int? FatherId { get; set; }
        [Column("INDICE")]
        public int? Indice { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(128)]
        public string Descricao { get; set; }
        [Required]
        [Column("OPERACAO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Operacao { get; set; }
        [Column("CODIGO_AUXILIAR")]
        [StringLength(64)]
        public string CodigoAuxiliar { get; set; }
    }
}
