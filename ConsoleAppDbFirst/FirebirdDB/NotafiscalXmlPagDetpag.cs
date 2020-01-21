using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_PAG_DETPAG      ")]
    public partial class NotafiscalXmlPagDetpag
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("DETPAG_INDPAG")]
        [StringLength(1)]
        public string DetpagIndpag { get; set; }
        [Column("DETPAG_TPAG")]
        [StringLength(2)]
        public string DetpagTpag { get; set; }
        [Column("DETPAG_VPAG", TypeName = "DECIMAL(15, 2)")]
        public decimal? DetpagVpag { get; set; }
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
