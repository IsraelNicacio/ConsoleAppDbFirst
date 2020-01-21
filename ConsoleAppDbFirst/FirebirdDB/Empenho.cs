using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("EMPENHO                        ")]
    public partial class Empenho
    {
        [Column("NUMERO")]
        [StringLength(32)]
        public string Numero { get; set; }
        [Column("DATA_EMISSAO")]
        public DateTime DataEmissao { get; set; }
        [Column("DATA_RECEBIMENTO")]
        public DateTime? DataRecebimento { get; set; }
        [Column("PRAZO_ENTREGA")]
        public DateTime? PrazoEntrega { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal Valor { get; set; }
        [Column("OBSERVACOES")]
        [StringLength(2048)]
        public string Observacoes { get; set; }
        [Column("TAG")]
        public int Tag { get; set; }
    }
}
