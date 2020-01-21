using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("EVENTOCANCNFE                  ")]
    public partial class Eventocancnfe
    {
        [Column("CHNFE")]
        [StringLength(44)]
        public string Chnfe { get; set; }
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
        [Column("DHREGEVENTO")]
        public DateTime Dhregevento { get; set; }
        [Required]
        [Column("EVTCANCNFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Evtcancnfe { get; set; }
        [Required]
        [Column("RETEVTCANCNFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Retevtcancnfe { get; set; }
    }
}
