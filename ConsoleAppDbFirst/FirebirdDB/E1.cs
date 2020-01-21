using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("E1                             ")]
    public partial class E1
    {
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Required]
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Column("IM")]
        [StringLength(14)]
        public string Im { get; set; }
        [Required]
        [Column("RAZAO_SOCIAL")]
        [StringLength(50)]
        public string RazaoSocial { get; set; }
        [Required]
        [Column("NUMERO_FABRICACAO")]
        [StringLength(20)]
        public string NumeroFabricacao { get; set; }
        [Column("MF_ADICIONAL", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string MfAdicional { get; set; }
        [Required]
        [Column("TIPO_ECF")]
        [StringLength(7)]
        public string TipoEcf { get; set; }
        [Required]
        [Column("MARCA_ECF")]
        [StringLength(20)]
        public string MarcaEcf { get; set; }
        [Required]
        [Column("MODELO_ECF")]
        [StringLength(20)]
        public string ModeloEcf { get; set; }
        [Column("DATA_ESTOQUE", TypeName = "DATE")]
        public DateTime DataEstoque { get; set; }
        [Column("HORA_ESTOQUE")]
        public TimeSpan HoraEstoque { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
