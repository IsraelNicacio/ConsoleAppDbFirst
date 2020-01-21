using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_CANCELAMENTO               ")]
    public partial class CteCancelamento
    {
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Required]
        [Column("NPROTAUTORIZACAO")]
        [StringLength(15)]
        public string Nprotautorizacao { get; set; }
        [Required]
        [Column("NPROTCANCELAMENTO")]
        [StringLength(15)]
        public string Nprotcancelamento { get; set; }
        [Required]
        [Column("XJUST")]
        [StringLength(255)]
        public string Xjust { get; set; }
        [Column("DHRECBTO")]
        public DateTime Dhrecbto { get; set; }
        [Required]
        [Column("XMLENTRADA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlentrada { get; set; }
        [Required]
        [Column("XMLRETORNO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlretorno { get; set; }
    }
}
