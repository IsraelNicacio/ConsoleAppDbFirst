using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_ITEM_ESTOQUE         ")]
    public partial class PdvVendaItemEstoque
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("ESTOQUE_ID")]
        public long EstoqueId { get; set; }
    }
}
