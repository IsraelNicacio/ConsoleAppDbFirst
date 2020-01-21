using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("FLUXO_CAIXA                    ")]
    public partial class FluxoCaixa
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("OPERACAO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Operacao { get; set; }
        [Column("CONTA_CAPITAL_ID")]
        public int ContaCapitalId { get; set; }
        [Column("CENTRO_CUSTO_LUCRO")]
        public long? CentroCustoLucro { get; set; }
        [Column("PLANO_CONTA_ID")]
        public int? PlanoContaId { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
        [Column("LANCAMENTO_ID")]
        public long? LancamentoId { get; set; }
        [Column("DATA_REGISTRO")]
        public DateTime DataRegistro { get; set; }
        [Column("DATA_COMPETENCIA")]
        public DateTime DataCompetencia { get; set; }
        [Column("DATA_COMPENSACAO")]
        public DateTime DataCompensacao { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 4)")]
        public decimal Valor { get; set; }
        [Required]
        [Column("HISTORICO")]
        [StringLength(512)]
        public string Historico { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
    }
}
