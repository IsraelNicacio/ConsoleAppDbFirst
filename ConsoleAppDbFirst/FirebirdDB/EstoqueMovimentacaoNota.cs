using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO_NOTA      ")]
    public partial class EstoqueMovimentacaoNota
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
        [Column("SERIE")]
        [StringLength(4)]
        public string Serie { get; set; }
        [Column("SUBSERIE")]
        [StringLength(4)]
        public string Subserie { get; set; }
        [Column("NUMERO")]
        public int? Numero { get; set; }
        [Column("CHAVE")]
        [StringLength(44)]
        public string Chave { get; set; }
        [Column("DATA_EMISSAO")]
        public DateTime? DataEmissao { get; set; }
    }
}
