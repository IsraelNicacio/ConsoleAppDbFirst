using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_REMESSA_LOCAL        ")]
    public partial class TsBoletoRemessaLocal
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CEDENTE_BANCO_CODIGO")]
        [StringLength(10)]
        public string CedenteBancoCodigo { get; set; }
        [Column("CEDENTE_CONTA_NUMERO")]
        [StringLength(20)]
        public string CedenteContaNumero { get; set; }
        [Column("CEDENTE_CONVENIO_NUMERO")]
        [StringLength(20)]
        public string CedenteConvenioNumero { get; set; }
        [Column("SITUACAO")]
        [StringLength(32)]
        public string Situacao { get; set; }
        [Column("ARQUIVO_NOME")]
        [StringLength(128)]
        public string ArquivoNome { get; set; }
        [Column("ARQUIVO_REMESSA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string ArquivoRemessa { get; set; }
        [Column("TITULOS", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Titulos { get; set; }
        [Column("JSON", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Json { get; set; }
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
