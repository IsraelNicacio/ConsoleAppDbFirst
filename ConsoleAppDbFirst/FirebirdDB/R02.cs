using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R02                            ")]
    public partial class R02
    {
        [Column("NUMERO_FABRICACAO")]
        [StringLength(20)]
        public string NumeroFabricacao { get; set; }
        [Column("MF_ADICIONAL", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string MfAdicional { get; set; }
        [Required]
        [Column("MODELO_ECF")]
        [StringLength(20)]
        public string ModeloEcf { get; set; }
        [Column("NUMERO_USUARIO")]
        public int NumeroUsuario { get; set; }
        [Column("CRZ")]
        public int Crz { get; set; }
        [Column("COO")]
        public int Coo { get; set; }
        [Column("CRO")]
        public int Cro { get; set; }
        [Column("DATA_MOVIMENTO", TypeName = "DATE")]
        public DateTime DataMovimento { get; set; }
        [Column("DATA_EMISSAO", TypeName = "DATE")]
        public DateTime DataEmissao { get; set; }
        [Column("HORA_EMISSAO")]
        public TimeSpan HoraEmissao { get; set; }
        [Column("VENDA_BRUTA_DIARIA", TypeName = "DECIMAL(18, 2)")]
        public decimal VendaBrutaDiaria { get; set; }
        [Column("INCIDENCIA_DESCONTO_ISSQN", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IncidenciaDescontoIssqn { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
