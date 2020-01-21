using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_PAGAMENTO            ")]
    public partial class PdvVendaPagamento
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Required]
        [Column("TIPO")]
        [StringLength(2)]
        public string Tipo { get; set; }
        [Column("VALOR_BRUTO", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorBruto { get; set; }
        [Column("TROCO", TypeName = "DECIMAL(18, 2)")]
        public decimal Troco { get; set; }
        [Column("VALOR_LIQUIDO", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorLiquido { get; set; }
        [Column("STATUS")]
        public short Status { get; set; }
        [Column("CARTAO_TIPO_INTEGRACAO")]
        [StringLength(1)]
        public string CartaoTipoIntegracao { get; set; }
        [Column("CARTAO_CNPJ")]
        [StringLength(14)]
        public string CartaoCnpj { get; set; }
        [Column("CARTAO_BANDEIRA")]
        [StringLength(2)]
        public string CartaoBandeira { get; set; }
        [Column("CARTAO_AUTORIZACAO")]
        [StringLength(20)]
        public string CartaoAutorizacao { get; set; }
    }
}
