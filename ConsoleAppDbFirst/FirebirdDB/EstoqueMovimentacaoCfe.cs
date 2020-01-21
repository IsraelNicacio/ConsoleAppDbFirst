using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO_CFE       ")]
    public partial class EstoqueMovimentacaoCfe
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("MODELO")]
        [StringLength(2)]
        public string Modelo { get; set; }
        [Column("EMITENTE_INDICADOR")]
        [StringLength(1)]
        public string EmitenteIndicador { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
        [Column("NUMERO_SAT")]
        [StringLength(9)]
        public string NumeroSat { get; set; }
        [Column("NUMERO_CFE")]
        [StringLength(6)]
        public string NumeroCfe { get; set; }
        [Column("CHAVE_CFE")]
        [StringLength(44)]
        public string ChaveCfe { get; set; }
        [Column("DATA_EMISSAO")]
        public DateTime? DataEmissao { get; set; }
    }
}
