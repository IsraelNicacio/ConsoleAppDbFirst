using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("AUX_REGA100                    ")]
    public partial class AuxRega100
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("VL_SERV", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlServ { get; set; }
        [Column("VL_BC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBc { get; set; }
        [Column("VL_LIQ", TypeName = "DECIMAL(18, 2)")]
        public decimal VlLiq { get; set; }
        [Column("VL_DEDUCAO", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDeducao { get; set; }
        [Column("VL_DESC_COND", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDescCond { get; set; }
        [Column("VL_DESC_INC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDescInc { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("VL_IR", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIr { get; set; }
        [Column("VL_INSS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlInss { get; set; }
        [Column("VL_CSLL", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCsll { get; set; }
        [Column("VL_OUTRA_RET", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlOutraRet { get; set; }
        [Column("VL_ALIQ_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlAliqIss { get; set; }
        [Column("VL_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIss { get; set; }
        [Column("VL_ISS_RET", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIssRet { get; set; }
    }
}
