using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R03                            ")]
    public partial class R03
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
        [Column("DATA_MOVIMENTO", TypeName = "DATE")]
        public DateTime DataMovimento { get; set; }
        [Column("TOTALIZADOR_PARCIAL")]
        [StringLength(7)]
        public string TotalizadorParcial { get; set; }
        [Column("VALOR_ACUMULADO", TypeName = "DECIMAL(13, 2)")]
        public decimal ValorAcumulado { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
