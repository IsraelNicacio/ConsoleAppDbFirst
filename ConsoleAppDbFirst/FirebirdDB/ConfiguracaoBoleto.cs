using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONFIGURACAO_BOLETO            ")]
    public partial class ConfiguracaoBoleto
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CARTEIRA")]
        [StringLength(8)]
        public string Carteira { get; set; }
        [Column("ESPECIE_DOCUMENTO")]
        [StringLength(8)]
        public string EspecieDocumento { get; set; }
        [Column("JUROS_MULTA", TypeName = "DECIMAL(18, 4)")]
        public decimal JurosMulta { get; set; }
        [Required]
        [Column("ACEITE", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Aceite { get; set; }
        [Column("CODIGO_CONVENIO")]
        [StringLength(64)]
        public string CodigoConvenio { get; set; }
    }
}
