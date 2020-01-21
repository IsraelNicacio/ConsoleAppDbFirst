using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGF600                        ")]
    public partial class Regf600
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("IND_NAT_RET", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string IndNatRet { get; set; }
        [Column("DT_RET", TypeName = "DATE")]
        public DateTime DtRet { get; set; }
        [Column("VL_BC_RET", TypeName = "DECIMAL(18, 4)")]
        public decimal VlBcRet { get; set; }
        [Column("VL_RET", TypeName = "DECIMAL(18, 2)")]
        public decimal VlRet { get; set; }
        [Column("COD_REC")]
        [StringLength(4)]
        public string CodRec { get; set; }
        [Column("IND_NAT_REC")]
        public int? IndNatRec { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("VL_RET_PIS", TypeName = "NUMERIC(18, 2)")]
        public decimal VlRetPis { get; set; }
        [Column("VL_RET_COFINS", TypeName = "NUMERIC(18, 2)")]
        public decimal VlRetCofins { get; set; }
        [Column("IND_DEC")]
        public int IndDec { get; set; }
    }
}
