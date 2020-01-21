using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD120                        ")]
    public partial class Regd120
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_ITEM")]
        public int NumItem { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("COD_MUN_ORIG")]
        [StringLength(7)]
        public string CodMunOrig { get; set; }
        [Required]
        [Column("COD_MUN_DEST")]
        [StringLength(7)]
        public string CodMunDest { get; set; }
        [Column("VEIC_ID")]
        [StringLength(7)]
        public string VeicId { get; set; }
        [Column("UF_ID")]
        [StringLength(2)]
        public string UfId { get; set; }
    }
}
