using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_ESCRITA_PIS_COFINS         ")]
    public partial class CteEscritaPisCofins
    {
        [Column("TRIBUTO")]
        [StringLength(16)]
        public string Tributo { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("CONDICAO_IND_EMIT", TypeName = "CHAR(1) CHARACTER SET UTF8")]
        public string CondicaoIndEmit { get; set; }
        [Required]
        [Column("CONDICAO_IND_OPER", TypeName = "CHAR(1) CHARACTER SET UTF8")]
        public string CondicaoIndOper { get; set; }
        [Required]
        [Column("CONDICAO_CFOP", TypeName = "CHAR(4) CHARACTER SET UTF8")]
        public string CondicaoCfop { get; set; }
        [Column("ESCRITA_CST")]
        [StringLength(2)]
        public string EscritaCst { get; set; }
        [Column("ESCRITA_VL_ITEM")]
        [StringLength(1024)]
        public string EscritaVlItem { get; set; }
        [Column("ESCRITA_VL_BC")]
        [StringLength(1024)]
        public string EscritaVlBc { get; set; }
        [Column("ESCRITA_ALIQ")]
        [StringLength(1024)]
        public string EscritaAliq { get; set; }
        [Column("ESCRITA_COD_CTA")]
        [StringLength(60)]
        public string EscritaCodCta { get; set; }
        [Column("ESCRITA_IND_NAT_FRT")]
        [StringLength(2)]
        public string EscritaIndNatFrt { get; set; }
        [Column("ESCRITA_NAT_BC_CRED")]
        [StringLength(2)]
        public string EscritaNatBcCred { get; set; }
        [Column("CRIACAO_USUARIO_ID")]
        public int? CriacaoUsuarioId { get; set; }
        [Column("CRIACAO_DATA_HORA")]
        public DateTime? CriacaoDataHora { get; set; }
        [Column("ULTIMA_ATUALIZACAO_USUARIO_ID")]
        public int? UltimaAtualizacaoUsuarioId { get; set; }
        [Column("ULTIMA_ATUALIZACAO_DATA_HORA")]
        public DateTime? UltimaAtualizacaoDataHora { get; set; }
    }
}
