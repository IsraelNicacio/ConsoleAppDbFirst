using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_BOLETO_LOCAL         ")]
    public partial class TsBoletoBoletoLocal
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ID_INTEGRACAO")]
        [StringLength(32)]
        public string IdIntegracao { get; set; }
        [Column("SITUACAO")]
        [StringLength(32)]
        public string Situacao { get; set; }
        [Column("MOTIVO")]
        [StringLength(1024)]
        public string Motivo { get; set; }
        [Column("CEDENTE_BANCO_CODIGO")]
        [StringLength(10)]
        public string CedenteBancoCodigo { get; set; }
        [Column("CEDENTE_AGENCIA_NUMERO")]
        [StringLength(16)]
        public string CedenteAgenciaNumero { get; set; }
        [Column("CEDENTE_AGENCIA_DV")]
        [StringLength(2)]
        public string CedenteAgenciaDv { get; set; }
        [Column("CEDENTE_CONTA_NUMERO")]
        [StringLength(20)]
        public string CedenteContaNumero { get; set; }
        [Column("CEDENTE_CONTA_DV")]
        [StringLength(10)]
        public string CedenteContaDv { get; set; }
        [Column("CEDENTE_CARTEIRA_NUMERO")]
        [StringLength(8)]
        public string CedenteCarteiraNumero { get; set; }
        [Column("CEDENTE_CARTEIRA_VARIACAO")]
        [StringLength(3)]
        public string CedenteCarteiraVariacao { get; set; }
        [Column("CEDENTE_CONVENIO_NUMERO")]
        [StringLength(20)]
        public string CedenteConvenioNumero { get; set; }
        [Column("SACADO_CPF_CNPJ")]
        [StringLength(14)]
        public string SacadoCpfCnpj { get; set; }
        [Column("SACADO_NOME")]
        [StringLength(200)]
        public string SacadoNome { get; set; }
        [Column("SACADO_ENDERECO_NUMERO")]
        [StringLength(20)]
        public string SacadoEnderecoNumero { get; set; }
        [Column("SACADO_ENDERECO_BAIRRO")]
        [StringLength(100)]
        public string SacadoEnderecoBairro { get; set; }
        [Column("SACADO_ENDERECO_CEP")]
        [StringLength(8)]
        public string SacadoEnderecoCep { get; set; }
        [Column("SACADO_ENDERECO_CIDADE")]
        [StringLength(50)]
        public string SacadoEnderecoCidade { get; set; }
        [Column("SACADO_ENDERECO_COMPLEMENTO")]
        [StringLength(100)]
        public string SacadoEnderecoComplemento { get; set; }
        [Column("SACADO_ENDERECO_LOGRADOURO")]
        [StringLength(200)]
        public string SacadoEnderecoLogradouro { get; set; }
        [Column("SACADO_ENDERECO_PAIS")]
        [StringLength(50)]
        public string SacadoEnderecoPais { get; set; }
        [Column("SACADO_ENDERECO_UF")]
        [StringLength(2)]
        public string SacadoEnderecoUf { get; set; }
        [Column("SACADO_EMAIL")]
        [StringLength(200)]
        public string SacadoEmail { get; set; }
        [Column("SACADO_TELEFONE")]
        [StringLength(11)]
        public string SacadoTelefone { get; set; }
        [Column("SACADO_CELULAR")]
        [StringLength(11)]
        public string SacadoCelular { get; set; }
        [Column("AVALISTA_CPF_CNPJ")]
        [StringLength(14)]
        public string AvalistaCpfCnpj { get; set; }
        [Column("AVALISTA_NOME")]
        [StringLength(200)]
        public string AvalistaNome { get; set; }
        [Column("TITULO_NOSSO_NUMERO")]
        public int? TituloNossoNumero { get; set; }
        [Column("TITULO_DOCUMENTO_ESPECIE")]
        [StringLength(4)]
        public string TituloDocumentoEspecie { get; set; }
        [Column("TITULO_DOCUMENTO_NUMERO")]
        [StringLength(50)]
        public string TituloDocumentoNumero { get; set; }
        [Column("TITULO_DOCUMENTO_DATA", TypeName = "DATE")]
        public DateTime? TituloDocumentoData { get; set; }
        [Column("TITULO_DATA_EMISSAO", TypeName = "DATE")]
        public DateTime? TituloDataEmissao { get; set; }
        [Column("TITULO_DATA_VENCIMENTO", TypeName = "DATE")]
        public DateTime? TituloDataVencimento { get; set; }
        [Column("TITULO_DATA_DESCONTO", TypeName = "DATE")]
        public DateTime? TituloDataDesconto { get; set; }
        [Column("TITULO_DATA_JUROS", TypeName = "DATE")]
        public DateTime? TituloDataJuros { get; set; }
        [Column("TITULO_DATA_MULTA", TypeName = "DATE")]
        public DateTime? TituloDataMulta { get; set; }
        [Column("TITULO_VALOR_DOCUMENTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorDocumento { get; set; }
        [Column("TITULO_VALOR_DESCONTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorDesconto { get; set; }
        [Column("TITULO_VALOR_ABATIMENTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorAbatimento { get; set; }
        [Column("TITULO_VALOR_OUTRAS_DEDUCOES", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorOutrasDeducoes { get; set; }
        [Column("TITULO_VALOR_JUROS", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorJuros { get; set; }
        [Column("TITULO_VALOR_MULTA", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorMulta { get; set; }
        [Column("TITULO_VALOR_OUTROS_ACRESCIMOS", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorOutrosAcrescimos { get; set; }
        [Column("TITULO_VALOR_COBRADO", TypeName = "DECIMAL(18, 2)")]
        public decimal? TituloValorCobrado { get; set; }
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
        [Column("TITULO_LINHA_DIGITAVEL")]
        [StringLength(200)]
        public string TituloLinhaDigitavel { get; set; }
        [Column("IMPRESSAO_VISUALIZADA")]
        public short? ImpressaoVisualizada { get; set; }
        [Column("PAGAMENTO_REALIZADO")]
        public short? PagamentoRealizado { get; set; }
        [Column("PAGAMENTO_DATA", TypeName = "DATE")]
        public DateTime? PagamentoData { get; set; }
        [Column("PAGAMENTO_DATA_CREDITO", TypeName = "DATE")]
        public DateTime? PagamentoDataCredito { get; set; }
        [Column("PAGAMENTO_VALOR_CREDITO", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorCredito { get; set; }
        [Column("PAGAMENTO_VALOR_PAGO", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorPago { get; set; }
        [Column("PAGAMENTO_VALOR_TAXA_COBRANCA", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorTaxaCobranca { get; set; }
        [Column("PAGAMENTO_VALOR_OUTRAS_DESPESAS", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorOutrasDespesas { get; set; }
        [Column("PAGAMENTO_VALOR_IOF", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorIof { get; set; }
        [Column("PAGAMENTO_VALOR_OUTROS_CREDITOS", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorOutrosCreditos { get; set; }
        [Column("PAGAMENTO_VALOR_DESCONTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorDesconto { get; set; }
        [Column("PAGAMENTO_VALOR_ACRESCIMOS", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorAcrescimos { get; set; }
        [Column("PAGAMENTO_VALOR_ABATIMENTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? PagamentoValorAbatimento { get; set; }
        [Column("OCORRENCIA_DATA", TypeName = "DATE")]
        public DateTime? OcorrenciaData { get; set; }
        [Column("JSON", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Json { get; set; }
        [Column("LANCAMENTO_ID")]
        public long? LancamentoId { get; set; }
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
