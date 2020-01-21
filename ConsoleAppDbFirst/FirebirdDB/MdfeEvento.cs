using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE_EVENTO                    ")]
    public partial class MdfeEvento
    {
        [Column("CHMDFE")]
        [StringLength(44)]
        public string Chmdfe { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("TPEVENTO")]
        public int Tpevento { get; set; }
        [Column("NSEQEVENTO")]
        public int Nseqevento { get; set; }
        [Required]
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("DHREGEVENTO")]
        public DateTime Dhregevento { get; set; }
        [Required]
        [Column("EVENTOMDFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Eventomdfe { get; set; }
        [Required]
        [Column("RETEVENTOMDFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Reteventomdfe { get; set; }
    }
}
