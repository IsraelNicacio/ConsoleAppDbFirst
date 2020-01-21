using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_MATRIZ_ESCRITURACAO        ")]
    public partial class CteMatrizEscrituracao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("TRIBUTO")]
        [StringLength(16)]
        public string Tributo { get; set; }
        [Required]
        [Column("IND_EMIT", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndEmit { get; set; }
        [Required]
        [Column("IND_OPER", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndOper { get; set; }
        [Required]
        [Column("CFOP", TypeName = "CHAR(4) CHARACTER SET UNICODE_FSS")]
        public string Cfop { get; set; }
        [Required]
        [Column("CST")]
        [StringLength(3)]
        public string Cst { get; set; }
        [Column("CFOP_ESCRITA", TypeName = "CHAR(4) CHARACTER SET UNICODE_FSS")]
        public string CfopEscrita { get; set; }
        [Required]
        [Column("CST_ESCRITA")]
        [StringLength(3)]
        public string CstEscrita { get; set; }
        [Column("ALIQ_ESCRITA", TypeName = "DECIMAL(5, 2)")]
        public decimal AliqEscrita { get; set; }
    }
}
