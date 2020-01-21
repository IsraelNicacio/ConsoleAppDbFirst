using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_ESCRITA_ICMS        ")]
    public partial class NotafiscalEscritaIcms
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CONDICAO_COD_MOD")]
        [StringLength(2)]
        public string CondicaoCodMod { get; set; }
        [Required]
        [Column("CONDICAO_IND_EMIT")]
        [StringLength(2)]
        public string CondicaoIndEmit { get; set; }
        [Required]
        [Column("CONDICAO_IND_OPER")]
        [StringLength(2)]
        public string CondicaoIndOper { get; set; }
        [Required]
        [Column("CONDICAO_CFOP")]
        [StringLength(4)]
        public string CondicaoCfop { get; set; }
        [Required]
        [Column("CONDICAO_CST_ICMS")]
        [StringLength(4)]
        public string CondicaoCstIcms { get; set; }
        [Column("CONDICAO_COD_PART")]
        public long? CondicaoCodPart { get; set; }
        [Column("CONDICAO_PRODUTO_CODIGO")]
        [StringLength(60)]
        public string CondicaoProdutoCodigo { get; set; }
        [Column("CONDICAO_PRODUTO_GRUPO")]
        public int? CondicaoProdutoGrupo { get; set; }
        [Column("CONDICAO_PRODUTO_TIPO_ITEM")]
        [StringLength(2)]
        public string CondicaoProdutoTipoItem { get; set; }
        [Column("ESCRITA_CST_ICMS")]
        [StringLength(4)]
        public string EscritaCstIcms { get; set; }
        [Column("ESCRITA_VL_BC_ICMS")]
        [StringLength(512)]
        public string EscritaVlBcIcms { get; set; }
        [Column("ESCRITA_ALIQ_ICMS")]
        [StringLength(512)]
        public string EscritaAliqIcms { get; set; }
        [Column("ESCRITA_VL_ICMS")]
        [StringLength(512)]
        public string EscritaVlIcms { get; set; }
        [Column("ESCRITA_VL_BC_ICMS_ST")]
        [StringLength(512)]
        public string EscritaVlBcIcmsSt { get; set; }
        [Column("ESCRITA_ALIQ_ICMS_ST")]
        [StringLength(512)]
        public string EscritaAliqIcmsSt { get; set; }
        [Column("ESCRITA_VL_ICMS_ST")]
        [StringLength(512)]
        public string EscritaVlIcmsSt { get; set; }
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
