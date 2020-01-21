using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_NOTAFISCAL           ")]
    public partial class PdvVendaNotafiscal
    {
        [Column("PDV_VENDA_ID")]
        public long PdvVendaId { get; set; }
        [Column("NOTAFISCAL_ID")]
        public long NotafiscalId { get; set; }
    }
}
