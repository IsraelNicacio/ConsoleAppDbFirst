using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_TRIBUTACAO_GRUPO    ")]
    public partial class NotafiscalTributacaoGrupo
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PRODUTO_GRUPO_ID")]
        public int ProdutoGrupoId { get; set; }
        [Column("INDICADOR_CONSUMIDOR_FINAL")]
        public short IndicadorConsumidorFinal { get; set; }
        [Column("INDICADOR_IE_DESTINATARIO")]
        public short IndicadorIeDestinatario { get; set; }
        [Column("INDICADOR_PRODUTO_IMPORTADO")]
        public short IndicadorProdutoImportado { get; set; }
        [Column("NOTAFISCAL_OPERACAO_ID")]
        public int NotafiscalOperacaoId { get; set; }
        [Column("NOTAFISCAL_TRIBUTACAO_ID")]
        public int? NotafiscalTributacaoId { get; set; }
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
