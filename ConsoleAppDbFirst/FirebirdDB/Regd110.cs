using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGD110                        ")]
    public partial class Regd110
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_ITEM")]
        public int NumItem { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("VL_SERV", TypeName = "DECIMAL(18, 2)")]
        public decimal VlServ { get; set; }
        [Column("VL_OUT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlOut { get; set; }
    }
}
