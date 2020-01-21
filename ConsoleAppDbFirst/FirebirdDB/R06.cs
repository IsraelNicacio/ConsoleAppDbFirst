using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R06                            ")]
    public partial class R06
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
        [Column("COO")]
        public int Coo { get; set; }
        [Column("GNF")]
        public int? Gnf { get; set; }
        [Column("GRG")]
        public int? Grg { get; set; }
        [Column("CDC")]
        public int? Cdc { get; set; }
        [Required]
        [Column("DENOMINACAO")]
        [StringLength(2)]
        public string Denominacao { get; set; }
        [Column("DATA_FINAL_EMISSAO", TypeName = "DATE")]
        public DateTime DataFinalEmissao { get; set; }
        [Column("HORA_FINAL_EMISSAO")]
        public TimeSpan HoraFinalEmissao { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
