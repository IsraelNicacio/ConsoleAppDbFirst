using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("R01                            ")]
    public partial class R01
    {
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
        [Required]
        [Column("VERSAO_SB")]
        [StringLength(10)]
        public string VersaoSb { get; set; }
        [Column("DATA_INSTALACAO_SB", TypeName = "DATE")]
        public DateTime? DataInstalacaoSb { get; set; }
        [Column("HORA_INSTALACAO_SB")]
        public TimeSpan? HoraInstalacaoSb { get; set; }
        [Column("NUMERO_SEQUENCIAL_ECF")]
        public int NumeroSequencialEcf { get; set; }
        [Required]
        [Column("CNPJ_USUARIO")]
        [StringLength(14)]
        public string CnpjUsuario { get; set; }
        [Required]
        [Column("IE_USUARIO")]
        [StringLength(14)]
        public string IeUsuario { get; set; }
        [Required]
        [Column("CODIGO_IDENTIFICACAO")]
        [StringLength(6)]
        public string CodigoIdentificacao { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
