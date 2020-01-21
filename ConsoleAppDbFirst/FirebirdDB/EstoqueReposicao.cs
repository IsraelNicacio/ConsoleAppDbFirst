using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_REPOSICAO              ")]
    public partial class EstoqueReposicao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PROPRIEDADE_INDICADOR")]
        public short PropriedadeIndicador { get; set; }
        [Column("PROPRIEDADE_PESSOA_ID")]
        public long? PropriedadePessoaId { get; set; }
        [Required]
        [Column("PRODUTO_CODIGO")]
        [StringLength(60)]
        public string ProdutoCodigo { get; set; }
        [Column("X_GRADE_EIXO_ITEM_ID")]
        public int? XGradeEixoItemId { get; set; }
        [Column("Y_GRADE_EIXO_ITEM_ID")]
        public int? YGradeEixoItemId { get; set; }
        [Column("QTD_MIN", TypeName = "DECIMAL(18, 3)")]
        public decimal QtdMin { get; set; }
        [Column("QTD_MAX", TypeName = "DECIMAL(18, 3)")]
        public decimal? QtdMax { get; set; }
        [Column("PONTO_REPOSICAO", TypeName = "DECIMAL(18, 3)")]
        public decimal? PontoReposicao { get; set; }
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
