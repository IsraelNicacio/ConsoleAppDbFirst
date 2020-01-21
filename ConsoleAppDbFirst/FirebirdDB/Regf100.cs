using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGF100                        ")]
    public partial class Regf100
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("IND_OPER", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndOper { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Column("DT_OPER", TypeName = "DATE")]
        public DateTime DtOper { get; set; }
        [Column("VL_OPER", TypeName = "NUMERIC(18, 2)")]
        public decimal VlOper { get; set; }
        [Required]
        [Column("CST_PIS")]
        [StringLength(2)]
        public string CstPis { get; set; }
        [Column("VL_BC_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcPis { get; set; }
        [Column("ALIQ_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? AliqPis { get; set; }
        [Column("VL_PIS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlPis { get; set; }
        [Required]
        [Column("CST_COFINS")]
        [StringLength(2)]
        public string CstCofins { get; set; }
        [Column("VL_BC_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcCofins { get; set; }
        [Column("ALIQ_COFINS", TypeName = "DECIMAL(6, 2)")]
        public decimal? AliqCofins { get; set; }
        [Column("VL_COFINS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCofins { get; set; }
        [Column("NAT_BC_CRED", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string NatBcCred { get; set; }
        [Column("IND_ORIG_CRED", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string IndOrigCred { get; set; }
        [Column("COD_CCUS")]
        [StringLength(60)]
        public string CodCcus { get; set; }
        [Column("DESC_DOC_OPER", TypeName = "BLOB SUB_TYPE TEXT")]
        public string DescDocOper { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
