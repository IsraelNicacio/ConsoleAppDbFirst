using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PDV_VENDA_AUTORIZACAO          ")]
    public partial class PdvVendaAutorizacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("OPERADOR")]
        public long Operador { get; set; }
        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }
        [Column("TIPO_OPERACAO")]
        public short TipoOperacao { get; set; }
    }
}
