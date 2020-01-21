using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGA100                        ")]
    public partial class Rega100
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("IND_OPER")]
        [StringLength(1)]
        public string IndOper { get; set; }
        [Required]
        [Column("IND_EMIT")]
        [StringLength(1)]
        public string IndEmit { get; set; }
        [Column("COD_PART")]
        public long? CodPart { get; set; }
        [Column("COD_SIT")]
        public int CodSit { get; set; }
        [Column("SER")]
        [StringLength(20)]
        public string Ser { get; set; }
        [Column("SUB")]
        [StringLength(20)]
        public string Sub { get; set; }
        [Required]
        [Column("NUM_DOC")]
        [StringLength(60)]
        public string NumDoc { get; set; }
        [Column("CHV_NFSE")]
        [StringLength(60)]
        public string ChvNfse { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("DT_EXE_SERV")]
        public DateTime? DtExeServ { get; set; }
        [Column("VL_DOC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDoc { get; set; }
        [Column("IND_PGTO")]
        [StringLength(1)]
        public string IndPgto { get; set; }
        [Column("VL_DESC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDesc { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcPis { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("VL_PIS_RET", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPisRet { get; set; }
        [Column("VL_COFINS_RET", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofinsRet { get; set; }
        [Column("VL_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIss { get; set; }
    }
}
