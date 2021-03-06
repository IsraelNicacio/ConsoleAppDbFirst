﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_ESCRITA_PIS         ")]
    public partial class NotafiscalEscritaPis
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
        [Column("CONDICAO_CST_PIS")]
        [StringLength(2)]
        public string CondicaoCstPis { get; set; }
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
        [Column("ESCRITA_CST_PIS")]
        [StringLength(2)]
        public string EscritaCstPis { get; set; }
        [Column("ESCRITA_VL_BC_PIS")]
        [StringLength(512)]
        public string EscritaVlBcPis { get; set; }
        [Column("ESCRITA_ALIQ_PIS")]
        [StringLength(512)]
        public string EscritaAliqPis { get; set; }
        [Column("ESCRITA_QUANT_BC_PIS")]
        [StringLength(512)]
        public string EscritaQuantBcPis { get; set; }
        [Column("ESCRITA_ALIQ_PIS_QUANT")]
        [StringLength(512)]
        public string EscritaAliqPisQuant { get; set; }
        [Column("ESCRITA_VL_PIS")]
        [StringLength(512)]
        public string EscritaVlPis { get; set; }
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
