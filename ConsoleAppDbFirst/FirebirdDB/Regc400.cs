using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC400                        ")]
    public partial class Regc400
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Required]
        [Column("ECF_MOD")]
        [StringLength(20)]
        public string EcfMod { get; set; }
        [Required]
        [Column("ECF_FAB")]
        [StringLength(20)]
        public string EcfFab { get; set; }
        [Column("ECF_CX")]
        public int EcfCx { get; set; }
    }
}
