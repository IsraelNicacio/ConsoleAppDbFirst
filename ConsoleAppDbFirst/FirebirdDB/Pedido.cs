﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PEDIDO                         ")]
    public partial class Pedido
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Column("ORCAMENTO_ID")]
        public long? OrcamentoId { get; set; }
        [Column("PRODUCAO_ID")]
        public long? ProducaoId { get; set; }
        [Column("TIPO")]
        public int Tipo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(128)]
        public string Descricao { get; set; }
        [Column("DATA")]
        public DateTime Data { get; set; }
        [Column("DATA_VALIDADE")]
        public DateTime? DataValidade { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
        [Column("VENDEDOR_ID")]
        public long? VendedorId { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal Valor { get; set; }
        [Column("VALOR_COTACAO", TypeName = "DECIMAL(18, 2)")]
        public decimal ValorCotacao { get; set; }
        [Column("COND_PAGAMENTO")]
        public int CondPagamento { get; set; }
        [Column("QTDE_PARCELAS")]
        public int QtdeParcelas { get; set; }
        [Column("DATA_PARCELA")]
        public DateTime DataParcela { get; set; }
        [Required]
        [Column("MOEDA_ID")]
        [StringLength(6)]
        public string MoedaId { get; set; }
        [Column("OBSERVACOES")]
        [StringLength(1024)]
        public string Observacoes { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }
        [Column("CONTA_CAPITAL_ID")]
        public int? ContaCapitalId { get; set; }
        [Column("PLANO_CONTAS_ID")]
        public int? PlanoContasId { get; set; }
        [Column("CENTRO_CUSTO_LUCRO")]
        public long? CentroCustoLucro { get; set; }
        [Column("FORMA_PAGAMENTO_ID")]
        public int? FormaPagamentoId { get; set; }
        [Column("HISTORICO")]
        [StringLength(512)]
        public string Historico { get; set; }
        [Column("DATA_COMPETENCIA")]
        public DateTime? DataCompetencia { get; set; }
        [Column("TIPO_DOCUMENTO_FINANCEIRO_ID")]
        public int? TipoDocumentoFinanceiroId { get; set; }
        [Column("NUMERO_DOCUMENTO")]
        [StringLength(64)]
        public string NumeroDocumento { get; set; }
        [Column("FREQUENCIA_PARCELA")]
        public int? FrequenciaParcela { get; set; }
        [Column("INTERVALO_DIAS")]
        public int? IntervaloDias { get; set; }
        [Column("FINANCEIRO")]
        public int Financeiro { get; set; }
        [Column("ESTOQUE")]
        public int Estoque { get; set; }
        [Column("NFE")]
        public int Nfe { get; set; }
        [Column("NFCE")]
        public int Nfce { get; set; }
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
