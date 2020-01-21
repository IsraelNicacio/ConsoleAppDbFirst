using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PROPOSTA                       ")]
    public partial class Proposta
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("DATA")]
        public DateTime Data { get; set; }
        [Column("DATA_VALIDADE")]
        public DateTime DataValidade { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }
        [Column("OBSERVACOES")]
        [StringLength(1024)]
        public string Observacoes { get; set; }
    }
}
