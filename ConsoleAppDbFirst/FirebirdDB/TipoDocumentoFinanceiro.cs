using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TIPO_DOCUMENTO_FINANCEIRO      ")]
    public partial class TipoDocumentoFinanceiro
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("DESCRICAO")]
        [StringLength(60)]
        public string Descricao { get; set; }
        [Column("ESPECIE")]
        [StringLength(2)]
        public string Especie { get; set; }
    }
}
