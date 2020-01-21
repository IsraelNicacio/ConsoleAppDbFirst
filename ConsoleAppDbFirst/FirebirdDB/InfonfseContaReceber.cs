using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("INFONFSE_CONTA_RECEBER         ")]
    public partial class InfonfseContaReceber
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("RPS_TIPO")]
        public short? RpsTipo { get; set; }
        [Column("RPS_SERIE")]
        [StringLength(5)]
        public string RpsSerie { get; set; }
        [Column("RPS_NUMERO")]
        public long? RpsNumero { get; set; }
        [Column("NFSE_CNPJ")]
        [StringLength(14)]
        public string NfseCnpj { get; set; }
        [Column("NFSE_NUMERO")]
        public long? NfseNumero { get; set; }
        [Column("NFSE_CODIGO")]
        [StringLength(9)]
        public string NfseCodigo { get; set; }
    }
}
