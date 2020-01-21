using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("INSTRUCAO_BOLETO               ")]
    public partial class InstrucaoBoleto
    {
        [Column("ID_BOLETO")]
        public int IdBoleto { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("CODIGO_INSTRUCAO")]
        public int CodigoInstrucao { get; set; }
        [Column("NUM_DIAS")]
        public int? NumDias { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 4)")]
        public decimal? Valor { get; set; }
        [Column("TEXTO")]
        [StringLength(128)]
        public string Texto { get; set; }
    }
}
