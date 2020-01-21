using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CLEAN_WHEY_VENDAS              ")]
    public partial class CleanWheyVendas
    {
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
        [Column("FORMA_PAGAMENTO")]
        public short FormaPagamento { get; set; }
        [Required]
        [Column("TIPO_FRETE")]
        [StringLength(64)]
        public string TipoFrete { get; set; }
        [Column("VALOR_FRETE", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorFrete { get; set; }
        [Column("VALOR_DESCONTO", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorDesconto { get; set; }
        [Column("VALOR_ITENS", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorItens { get; set; }
        [Column("VALOR_TOTAL", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorTotal { get; set; }
        [Required]
        [Column("CLIENTE_CPF_CNPJ")]
        [StringLength(14)]
        public string ClienteCpfCnpj { get; set; }
        [Required]
        [Column("CLIENTE_NOME")]
        [StringLength(256)]
        public string ClienteNome { get; set; }
        [Required]
        [Column("JSON", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Json { get; set; }
        [Column("NOTAFISCAL_ID")]
        public long? NotafiscalId { get; set; }
        [Column("CRIACAO_USUARIO_ID")]
        public int? CriacaoUsuarioId { get; set; }
        [Column("CRIACAO_DATA_HORA")]
        public DateTime? CriacaoDataHora { get; set; }
        [Column("ULTIMA_ATUALIZACAO_USUARIO_ID")]
        public int? UltimaAtualizacaoUsuarioId { get; set; }
        [Column("ULTIMA_ATUALIZACAO_DATA_HORA")]
        public DateTime? UltimaAtualizacaoDataHora { get; set; }
    }
}
