using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_CONVENIO_LOCAL       ")]
    public partial class TsBoletoConvenioLocal
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("TITULO_NOSSO_NUMERO")]
        public int TituloNossoNumero { get; set; }
        [Column("TITULO_DOCUMENTO_ESPECIE")]
        [StringLength(50)]
        public string TituloDocumentoEspecie { get; set; }
        [Column("TITULO_ACEITE")]
        [StringLength(100)]
        public string TituloAceite { get; set; }
        [Column("TITULO_LOCAL_PAGAMENTO")]
        [StringLength(200)]
        public string TituloLocalPagamento { get; set; }
        [Column("TITULO_INSTRUCOES")]
        [StringLength(200)]
        public string TituloInstrucoes { get; set; }
        [Column("TITULO_MENSAGEM_01")]
        [StringLength(200)]
        public string TituloMensagem01 { get; set; }
        [Column("TITULO_MENSAGEM_02")]
        [StringLength(200)]
        public string TituloMensagem02 { get; set; }
        [Column("TITULO_MENSAGEM_03")]
        [StringLength(200)]
        public string TituloMensagem03 { get; set; }
        [Column("TITULO_INFORMACOES_ADICIONAIS")]
        [StringLength(200)]
        public string TituloInformacoesAdicionais { get; set; }
        [Column("TITULO_VARIACAO_CARTEIRA")]
        [StringLength(3)]
        public string TituloVariacaoCarteira { get; set; }
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
