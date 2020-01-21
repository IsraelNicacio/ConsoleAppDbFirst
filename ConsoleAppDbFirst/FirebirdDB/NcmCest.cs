using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NCM_CEST                       ")]
    public partial class NcmCest
    {
        [Column("NCM")]
        [StringLength(8)]
        public string Ncm { get; set; }
        [Column("CEST")]
        [StringLength(7)]
        public string Cest { get; set; }
        [Column("DESCRICAO")]
        [StringLength(1024)]
        public string Descricao { get; set; }
        [Column("PRODUTO_GRUPO_ID")]
        public int? ProdutoGrupoId { get; set; }
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
