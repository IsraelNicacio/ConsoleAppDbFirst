using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_ESCRITA_OPERACAO    ")]
    public partial class NotafiscalEscritaOperacao
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
        [Required]
        [Column("ESCRITA_CFOP")]
        [StringLength(4)]
        public string EscritaCfop { get; set; }
        [Column("ESCRITA_COD_NAT")]
        [StringLength(512)]
        public string EscritaCodNat { get; set; }
        [Column("ESCRITA_VL_ITEM")]
        [StringLength(512)]
        public string EscritaVlItem { get; set; }
        [Column("ESCRITA_VL_DESC")]
        [StringLength(512)]
        public string EscritaVlDesc { get; set; }
        [Column("ESCRITA_VL_ABAT_NT")]
        [StringLength(512)]
        public string EscritaVlAbatNt { get; set; }
        [Column("ESCRITA_VL_OPR")]
        [StringLength(512)]
        public string EscritaVlOpr { get; set; }
        [Column("ESCRITA_VL_ESTOQUE")]
        [StringLength(512)]
        public string EscritaVlEstoque { get; set; }
        [Column("ESCRITA_IND_MOV")]
        [StringLength(2)]
        public string EscritaIndMov { get; set; }
        [Column("ESCRITA_COD_CTA")]
        [StringLength(60)]
        public string EscritaCodCta { get; set; }
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
