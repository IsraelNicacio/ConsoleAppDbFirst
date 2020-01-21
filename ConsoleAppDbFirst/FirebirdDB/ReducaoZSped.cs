using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REDUCAO_Z_SPED                 ")]
    public partial class ReducaoZSped
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
        [Column("DATA_MOVIMENTO", TypeName = "DATE")]
        public DateTime DataMovimento { get; set; }
        [Required]
        [Column("REGISTROS", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Registros { get; set; }
    }
}
