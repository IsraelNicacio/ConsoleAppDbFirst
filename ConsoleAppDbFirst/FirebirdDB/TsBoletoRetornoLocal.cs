using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_RETORNO_LOCAL        ")]
    public partial class TsBoletoRetornoLocal
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ARQUIVO_NOME")]
        [StringLength(128)]
        public string ArquivoNome { get; set; }
        [Column("ARQUIVO_CONTEUDO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string ArquivoConteudo { get; set; }
        [Column("PROTOCOLO")]
        [StringLength(64)]
        public string Protocolo { get; set; }
        [Column("SITUACAO")]
        [StringLength(64)]
        public string Situacao { get; set; }
        [Column("MENSAGEM")]
        [StringLength(1024)]
        public string Mensagem { get; set; }
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
