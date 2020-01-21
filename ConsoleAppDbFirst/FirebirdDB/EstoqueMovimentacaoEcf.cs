using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO_ECF       ")]
    public partial class EstoqueMovimentacaoEcf
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
        [Column("NUMERO_FABRICACAO")]
        [StringLength(32)]
        public string NumeroFabricacao { get; set; }
        [Column("CCF")]
        public int? Ccf { get; set; }
        [Column("COO")]
        public int? Coo { get; set; }
        [Column("DATA_EMISSAO")]
        public DateTime? DataEmissao { get; set; }
    }
}
