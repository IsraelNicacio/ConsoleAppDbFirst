using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PEDIDO_PAGAMENTO               ")]
    public partial class PedidoPagamento
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("INDPAG")]
        [StringLength(1)]
        public string Indpag { get; set; }
        [Column("TPAG")]
        [StringLength(2)]
        public string Tpag { get; set; }
        [Column("VPAG", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vpag { get; set; }
        [Column("CARD_TPINTEGRA")]
        [StringLength(1)]
        public string CardTpintegra { get; set; }
        [Column("CARD_CNPJ")]
        [StringLength(14)]
        public string CardCnpj { get; set; }
        [Column("CARD_TBAND")]
        [StringLength(2)]
        public string CardTband { get; set; }
        [Column("CARD_CAUT")]
        [StringLength(20)]
        public string CardCaut { get; set; }
    }
}
