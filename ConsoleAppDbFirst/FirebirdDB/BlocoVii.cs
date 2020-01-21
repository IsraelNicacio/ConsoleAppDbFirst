using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("BLOCO_VII                      ")]
    public partial class BlocoVii
    {
        [Column("TABELA")]
        [StringLength(64)]
        public string Tabela { get; set; }
        [Column("REGISTROS")]
        public long Registros { get; set; }
        [Required]
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
    }
}
