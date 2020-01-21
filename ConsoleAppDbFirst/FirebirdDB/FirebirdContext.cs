using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleAppDbFirst.FirebirdDB
{
    public partial class FirebirdContext : DbContext
    {
        public FirebirdContext()
        {
        }

        public FirebirdContext(DbContextOptions<FirebirdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnalistaFornecedor> AnalistaFornecedor { get; set; }
        public virtual DbSet<AnalistaIbptCfop> AnalistaIbptCfop { get; set; }
        public virtual DbSet<AnalistaTributacao> AnalistaTributacao { get; set; }
        public virtual DbSet<AuxRega100> AuxRega100 { get; set; }
        public virtual DbSet<AuxRegc100> AuxRegc100 { get; set; }
        public virtual DbSet<AuxRegc101> AuxRegc101 { get; set; }
        public virtual DbSet<AuxRegc110> AuxRegc110 { get; set; }
        public virtual DbSet<AuxRegc120> AuxRegc120 { get; set; }
        public virtual DbSet<AuxRegc140> AuxRegc140 { get; set; }
        public virtual DbSet<AuxRegc141> AuxRegc141 { get; set; }
        public virtual DbSet<AuxRegc170> AuxRegc170 { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<BlocoVii> BlocoVii { get; set; }
        public virtual DbSet<Cancelamento> Cancelamento { get; set; }
        public virtual DbSet<CapptaOperacaoAprovada> CapptaOperacaoAprovada { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CentroCustoLucro> CentroCustoLucro { get; set; }
        public virtual DbSet<Cfop> Cfop { get; set; }
        public virtual DbSet<Clausula> Clausula { get; set; }
        public virtual DbSet<CleanWheyVendas> CleanWheyVendas { get; set; }
        public virtual DbSet<Composicao> Composicao { get; set; }
        public virtual DbSet<ComposicaoGrade> ComposicaoGrade { get; set; }
        public virtual DbSet<Configuracao> Configuracao { get; set; }
        public virtual DbSet<ConfiguracaoBoleto> ConfiguracaoBoleto { get; set; }
        public virtual DbSet<ConfiguracaoUsuario> ConfiguracaoUsuario { get; set; }
        public virtual DbSet<ContaCapital> ContaCapital { get; set; }
        public virtual DbSet<Contabilista> Contabilista { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Cte> Cte { get; set; }
        public virtual DbSet<CteCancelamento> CteCancelamento { get; set; }
        public virtual DbSet<CteEscritaIcms> CteEscritaIcms { get; set; }
        public virtual DbSet<CteEscritaPisCofins> CteEscritaPisCofins { get; set; }
        public virtual DbSet<CteEvento> CteEvento { get; set; }
        public virtual DbSet<CteInutilizacao> CteInutilizacao { get; set; }
        public virtual DbSet<CteMatrizEscrituracao> CteMatrizEscrituracao { get; set; }
        public virtual DbSet<CteNumeracao> CteNumeracao { get; set; }
        public virtual DbSet<CteXmlAnulacao> CteXmlAnulacao { get; set; }
        public virtual DbSet<CteXmlCarga> CteXmlCarga { get; set; }
        public virtual DbSet<CteXmlComplementado> CteXmlComplementado { get; set; }
        public virtual DbSet<CteXmlDestinatario> CteXmlDestinatario { get; set; }
        public virtual DbSet<CteXmlDocsNf> CteXmlDocsNf { get; set; }
        public virtual DbSet<CteXmlDocsNfe> CteXmlDocsNfe { get; set; }
        public virtual DbSet<CteXmlDocsOutros> CteXmlDocsOutros { get; set; }
        public virtual DbSet<CteXmlExpedidor> CteXmlExpedidor { get; set; }
        public virtual DbSet<CteXmlImposto> CteXmlImposto { get; set; }
        public virtual DbSet<CteXmlRecebedor> CteXmlRecebedor { get; set; }
        public virtual DbSet<CteXmlRemetente> CteXmlRemetente { get; set; }
        public virtual DbSet<CteXmlRodoMotorista> CteXmlRodoMotorista { get; set; }
        public virtual DbSet<CteXmlRodoValePedagio> CteXmlRodoValePedagio { get; set; }
        public virtual DbSet<CteXmlRodoVeiculo> CteXmlRodoVeiculo { get; set; }
        public virtual DbSet<CteXmlSeguro> CteXmlSeguro { get; set; }
        public virtual DbSet<CteXmlSubstituicao> CteXmlSubstituicao { get; set; }
        public virtual DbSet<CteXmlTomador> CteXmlTomador { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<E1> E1 { get; set; }
        public virtual DbSet<E2> E2 { get; set; }
        public virtual DbSet<Emitente> Emitente { get; set; }
        public virtual DbSet<Empenho> Empenho { get; set; }
        public virtual DbSet<EmpenhoItem> EmpenhoItem { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<EnderecoCobranca> EnderecoCobranca { get; set; }
        public virtual DbSet<EquivalenciaProduto> EquivalenciaProduto { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<EstoqueLocal> EstoqueLocal { get; set; }
        public virtual DbSet<EstoqueMovimentacao> EstoqueMovimentacao { get; set; }
        public virtual DbSet<EstoqueMovimentacaoCfe> EstoqueMovimentacaoCfe { get; set; }
        public virtual DbSet<EstoqueMovimentacaoEcf> EstoqueMovimentacaoEcf { get; set; }
        public virtual DbSet<EstoqueMovimentacaoFiscal> EstoqueMovimentacaoFiscal { get; set; }
        public virtual DbSet<EstoqueMovimentacaoGrade> EstoqueMovimentacaoGrade { get; set; }
        public virtual DbSet<EstoqueMovimentacaoNota> EstoqueMovimentacaoNota { get; set; }
        public virtual DbSet<EstoqueMovimentacaoValor> EstoqueMovimentacaoValor { get; set; }
        public virtual DbSet<EstoqueOperacao> EstoqueOperacao { get; set; }
        public virtual DbSet<EstoqueReposicao> EstoqueReposicao { get; set; }
        public virtual DbSet<EstoqueReserva> EstoqueReserva { get; set; }
        public virtual DbSet<EstoqueReservaGrade> EstoqueReservaGrade { get; set; }
        public virtual DbSet<Eventocancnfe> Eventocancnfe { get; set; }
        public virtual DbSet<FluxoCaixa> FluxoCaixa { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamento { get; set; }
        public virtual DbSet<Funcionalidade> Funcionalidade { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GradeEixo> GradeEixo { get; set; }
        public virtual DbSet<GradeEixoItem> GradeEixoItem { get; set; }
        public virtual DbSet<Grupousuario> Grupousuario { get; set; }
        public virtual DbSet<Icms> Icms { get; set; }
        public virtual DbSet<InfonfseContaReceber> InfonfseContaReceber { get; set; }
        public virtual DbSet<InfonfsePlanoContas> InfonfsePlanoContas { get; set; }
        public virtual DbSet<InstrucaoBoleto> InstrucaoBoleto { get; set; }
        public virtual DbSet<ItemOrcamento> ItemOrcamento { get; set; }
        public virtual DbSet<ItemPedido> ItemPedido { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<LocalArmazenagem> LocalArmazenagem { get; set; }
        public virtual DbSet<MatrizDespesas> MatrizDespesas { get; set; }
        public virtual DbSet<MatrizEscrituracao> MatrizEscrituracao { get; set; }
        public virtual DbSet<Mdfe> Mdfe { get; set; }
        public virtual DbSet<MdfeEvento> MdfeEvento { get; set; }
        public virtual DbSet<MdfeNumeracao> MdfeNumeracao { get; set; }
        public virtual DbSet<MdfeXmlCondutor> MdfeXmlCondutor { get; set; }
        public virtual DbSet<MdfeXmlCte> MdfeXmlCte { get; set; }
        public virtual DbSet<MdfeXmlInfmuncarrega> MdfeXmlInfmuncarrega { get; set; }
        public virtual DbSet<MdfeXmlNfe> MdfeXmlNfe { get; set; }
        public virtual DbSet<MdfeXmlRodoCiot> MdfeXmlRodoCiot { get; set; }
        public virtual DbSet<MdfeXmlRodoContratante> MdfeXmlRodoContratante { get; set; }
        public virtual DbSet<MdfeXmlRodoValePedagio> MdfeXmlRodoValePedagio { get; set; }
        public virtual DbSet<MdfeXmlSeguro> MdfeXmlSeguro { get; set; }
        public virtual DbSet<MdfeXmlSeguroAverbacao> MdfeXmlSeguroAverbacao { get; set; }
        public virtual DbSet<MdfeXmlVeictracao> MdfeXmlVeictracao { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Moeda> Moeda { get; set; }
        public virtual DbSet<NcmCest> NcmCest { get; set; }
        public virtual DbSet<Notafiscal> Notafiscal { get; set; }
        public virtual DbSet<NotafiscalEscritaCofins> NotafiscalEscritaCofins { get; set; }
        public virtual DbSet<NotafiscalEscritaIcms> NotafiscalEscritaIcms { get; set; }
        public virtual DbSet<NotafiscalEscritaIpi> NotafiscalEscritaIpi { get; set; }
        public virtual DbSet<NotafiscalEscritaOperacao> NotafiscalEscritaOperacao { get; set; }
        public virtual DbSet<NotafiscalEscritaPis> NotafiscalEscritaPis { get; set; }
        public virtual DbSet<NotafiscalEvento> NotafiscalEvento { get; set; }
        public virtual DbSet<NotafiscalInterface> NotafiscalInterface { get; set; }
        public virtual DbSet<NotafiscalInterfaceParametro> NotafiscalInterfaceParametro { get; set; }
        public virtual DbSet<NotafiscalInutilizacao> NotafiscalInutilizacao { get; set; }
        public virtual DbSet<NotafiscalNumeracao> NotafiscalNumeracao { get; set; }
        public virtual DbSet<NotafiscalOperacao> NotafiscalOperacao { get; set; }
        public virtual DbSet<NotafiscalTributacao> NotafiscalTributacao { get; set; }
        public virtual DbSet<NotafiscalTributacaoEstadual> NotafiscalTributacaoEstadual { get; set; }
        public virtual DbSet<NotafiscalTributacaoFederal> NotafiscalTributacaoFederal { get; set; }
        public virtual DbSet<NotafiscalTributacaoGrupo> NotafiscalTributacaoGrupo { get; set; }
        public virtual DbSet<NotafiscalTributacaoProduto> NotafiscalTributacaoProduto { get; set; }
        public virtual DbSet<NotafiscalXmlCobrDup> NotafiscalXmlCobrDup { get; set; }
        public virtual DbSet<NotafiscalXmlCobrFat> NotafiscalXmlCobrFat { get; set; }
        public virtual DbSet<NotafiscalXmlCompra> NotafiscalXmlCompra { get; set; }
        public virtual DbSet<NotafiscalXmlDest> NotafiscalXmlDest { get; set; }
        public virtual DbSet<NotafiscalXmlDet> NotafiscalXmlDet { get; set; }
        public virtual DbSet<NotafiscalXmlDetImposto> NotafiscalXmlDetImposto { get; set; }
        public virtual DbSet<NotafiscalXmlDetImpostodevol> NotafiscalXmlDetImpostodevol { get; set; }
        public virtual DbSet<NotafiscalXmlEntrega> NotafiscalXmlEntrega { get; set; }
        public virtual DbSet<NotafiscalXmlIcmstot> NotafiscalXmlIcmstot { get; set; }
        public virtual DbSet<NotafiscalXmlInfadicObscont> NotafiscalXmlInfadicObscont { get; set; }
        public virtual DbSet<NotafiscalXmlIssqntot> NotafiscalXmlIssqntot { get; set; }
        public virtual DbSet<NotafiscalXmlPagDetpag> NotafiscalXmlPagDetpag { get; set; }
        public virtual DbSet<NotafiscalXmlRefcte> NotafiscalXmlRefcte { get; set; }
        public virtual DbSet<NotafiscalXmlRefecf> NotafiscalXmlRefecf { get; set; }
        public virtual DbSet<NotafiscalXmlRefnf> NotafiscalXmlRefnf { get; set; }
        public virtual DbSet<NotafiscalXmlRefnfe> NotafiscalXmlRefnfe { get; set; }
        public virtual DbSet<NotafiscalXmlRefnfp> NotafiscalXmlRefnfp { get; set; }
        public virtual DbSet<NotafiscalXmlRetirada> NotafiscalXmlRetirada { get; set; }
        public virtual DbSet<NotafiscalXmlRettrib> NotafiscalXmlRettrib { get; set; }
        public virtual DbSet<NotafiscalXmlTransp> NotafiscalXmlTransp { get; set; }
        public virtual DbSet<Observacao> Observacao { get; set; }
        public virtual DbSet<Operacao> Operacao { get; set; }
        public virtual DbSet<Orcamento> Orcamento { get; set; }
        public virtual DbSet<OrcamentoItemGrade> OrcamentoItemGrade { get; set; }
        public virtual DbSet<PagadoraBeneficiaria> PagadoraBeneficiaria { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Pdv> Pdv { get; set; }
        public virtual DbSet<PdvAbertura> PdvAbertura { get; set; }
        public virtual DbSet<PdvFechamento> PdvFechamento { get; set; }
        public virtual DbSet<PdvParametro> PdvParametro { get; set; }
        public virtual DbSet<PdvSangria> PdvSangria { get; set; }
        public virtual DbSet<PdvSuprimento> PdvSuprimento { get; set; }
        public virtual DbSet<PdvVenda> PdvVenda { get; set; }
        public virtual DbSet<PdvVendaAutorizacao> PdvVendaAutorizacao { get; set; }
        public virtual DbSet<PdvVendaCancelamento> PdvVendaCancelamento { get; set; }
        public virtual DbSet<PdvVendaCliente> PdvVendaCliente { get; set; }
        public virtual DbSet<PdvVendaItem> PdvVendaItem { get; set; }
        public virtual DbSet<PdvVendaItemEstoque> PdvVendaItemEstoque { get; set; }
        public virtual DbSet<PdvVendaItemGrade> PdvVendaItemGrade { get; set; }
        public virtual DbSet<PdvVendaNotafiscal> PdvVendaNotafiscal { get; set; }
        public virtual DbSet<PdvVendaPagamento> PdvVendaPagamento { get; set; }
        public virtual DbSet<PdvVendaTransporte> PdvVendaTransporte { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoItemGrade> PedidoItemGrade { get; set; }
        public virtual DbSet<PedidoPagamento> PedidoPagamento { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaDownload> PessoaDownload { get; set; }
        public virtual DbSet<PlanoContas> PlanoContas { get; set; }
        public virtual DbSet<ProducaoClassificacao> ProducaoClassificacao { get; set; }
        public virtual DbSet<ProducaoProcesso> ProducaoProcesso { get; set; }
        public virtual DbSet<ProducaoProcessoGrade> ProducaoProcessoGrade { get; set; }
        public virtual DbSet<ProducaoProcessoItem> ProducaoProcessoItem { get; set; }
        public virtual DbSet<ProducaoProcessoItemGrade> ProducaoProcessoItemGrade { get; set; }
        public virtual DbSet<ProducaoRecurso> ProducaoRecurso { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoCofins> ProdutoCofins { get; set; }
        public virtual DbSet<ProdutoCombustivel> ProdutoCombustivel { get; set; }
        public virtual DbSet<ProdutoContaContabil> ProdutoContaContabil { get; set; }
        public virtual DbSet<ProdutoConversao> ProdutoConversao { get; set; }
        public virtual DbSet<ProdutoCredito> ProdutoCredito { get; set; }
        public virtual DbSet<ProdutoGrupo> ProdutoGrupo { get; set; }
        public virtual DbSet<ProdutoIpi> ProdutoIpi { get; set; }
        public virtual DbSet<ProdutoLote> ProdutoLote { get; set; }
        public virtual DbSet<ProdutoPis> ProdutoPis { get; set; }
        public virtual DbSet<ProdutoReceita> ProdutoReceita { get; set; }
        public virtual DbSet<ProdutoSped> ProdutoSped { get; set; }
        public virtual DbSet<Proposta> Proposta { get; set; }
        public virtual DbSet<R01> R01 { get; set; }
        public virtual DbSet<R02> R02 { get; set; }
        public virtual DbSet<R03> R03 { get; set; }
        public virtual DbSet<R04> R04 { get; set; }
        public virtual DbSet<R05> R05 { get; set; }
        public virtual DbSet<R05Grade> R05Grade { get; set; }
        public virtual DbSet<R06> R06 { get; set; }
        public virtual DbSet<R07> R07 { get; set; }
        public virtual DbSet<ReducaoZSintegra> ReducaoZSintegra { get; set; }
        public virtual DbSet<ReducaoZSped> ReducaoZSped { get; set; }
        public virtual DbSet<Reg0400> Reg0400 { get; set; }
        public virtual DbSet<Reg0450> Reg0450 { get; set; }
        public virtual DbSet<Reg0460> Reg0460 { get; set; }
        public virtual DbSet<Reg0500> Reg0500 { get; set; }
        public virtual DbSet<Reg1400> Reg1400 { get; set; }
        public virtual DbSet<Reg1600> Reg1600 { get; set; }
        public virtual DbSet<Reg1700> Reg1700 { get; set; }
        public virtual DbSet<Reg1710> Reg1710 { get; set; }
        public virtual DbSet<Rega100> Rega100 { get; set; }
        public virtual DbSet<Rega110> Rega110 { get; set; }
        public virtual DbSet<Rega111> Rega111 { get; set; }
        public virtual DbSet<Rega120> Rega120 { get; set; }
        public virtual DbSet<Rega170> Rega170 { get; set; }
        public virtual DbSet<Regb020> Regb020 { get; set; }
        public virtual DbSet<Regb025> Regb025 { get; set; }
        public virtual DbSet<Regc100> Regc100 { get; set; }
        public virtual DbSet<Regc101> Regc101 { get; set; }
        public virtual DbSet<Regc110> Regc110 { get; set; }
        public virtual DbSet<Regc112> Regc112 { get; set; }
        public virtual DbSet<Regc114> Regc114 { get; set; }
        public virtual DbSet<Regc120> Regc120 { get; set; }
        public virtual DbSet<Regc140> Regc140 { get; set; }
        public virtual DbSet<Regc141> Regc141 { get; set; }
        public virtual DbSet<Regc170> Regc170 { get; set; }
        public virtual DbSet<Regc176> Regc176 { get; set; }
        public virtual DbSet<Regc195> Regc195 { get; set; }
        public virtual DbSet<Regc300> Regc300 { get; set; }
        public virtual DbSet<Regc300Pagamento> Regc300Pagamento { get; set; }
        public virtual DbSet<Regc310> Regc310 { get; set; }
        public virtual DbSet<Regc321> Regc321 { get; set; }
        public virtual DbSet<Regc400> Regc400 { get; set; }
        public virtual DbSet<Regc405> Regc405 { get; set; }
        public virtual DbSet<Regc410> Regc410 { get; set; }
        public virtual DbSet<Regc420> Regc420 { get; set; }
        public virtual DbSet<Regc425> Regc425 { get; set; }
        public virtual DbSet<Regc490> Regc490 { get; set; }
        public virtual DbSet<Regc500> Regc500 { get; set; }
        public virtual DbSet<Regc501> Regc501 { get; set; }
        public virtual DbSet<Regc505> Regc505 { get; set; }
        public virtual DbSet<Regd100> Regd100 { get; set; }
        public virtual DbSet<Regd101> Regd101 { get; set; }
        public virtual DbSet<Regd101Fiscal> Regd101Fiscal { get; set; }
        public virtual DbSet<Regd105> Regd105 { get; set; }
        public virtual DbSet<Regd110> Regd110 { get; set; }
        public virtual DbSet<Regd120> Regd120 { get; set; }
        public virtual DbSet<Regd201> Regd201 { get; set; }
        public virtual DbSet<Regd205> Regd205 { get; set; }
        public virtual DbSet<Regd500> Regd500 { get; set; }
        public virtual DbSet<Regd501> Regd501 { get; set; }
        public virtual DbSet<Regd505> Regd505 { get; set; }
        public virtual DbSet<Regf100> Regf100 { get; set; }
        public virtual DbSet<Regf600> Regf600 { get; set; }
        public virtual DbSet<Regh005> Regh005 { get; set; }
        public virtual DbSet<Regh010> Regh010 { get; set; }
        public virtual DbSet<Regh020> Regh020 { get; set; }
        public virtual DbSet<Regk250> Regk250 { get; set; }
        public virtual DbSet<Regk255> Regk255 { get; set; }
        public virtual DbSet<RegraTributaria> RegraTributaria { get; set; }
        public virtual DbSet<RegraTributariaCte> RegraTributariaCte { get; set; }
        public virtual DbSet<RegraTributariaCteIcmsAliq> RegraTributariaCteIcmsAliq { get; set; }
        public virtual DbSet<RegraTributariaIcmsAliquota> RegraTributariaIcmsAliquota { get; set; }
        public virtual DbSet<SeguroCarga> SeguroCarga { get; set; }
        public virtual DbSet<TabelaPrecoCompra> TabelaPrecoCompra { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TipoConta> TipoConta { get; set; }
        public virtual DbSet<TipoDocumentoFinanceiro> TipoDocumentoFinanceiro { get; set; }
        public virtual DbSet<Transportadora> Transportadora { get; set; }
        public virtual DbSet<TsBoletoBoletoLocal> TsBoletoBoletoLocal { get; set; }
        public virtual DbSet<TsBoletoContaApi> TsBoletoContaApi { get; set; }
        public virtual DbSet<TsBoletoContaLocal> TsBoletoContaLocal { get; set; }
        public virtual DbSet<TsBoletoConvenioApi> TsBoletoConvenioApi { get; set; }
        public virtual DbSet<TsBoletoConvenioLocal> TsBoletoConvenioLocal { get; set; }
        public virtual DbSet<TsBoletoRemessaLocal> TsBoletoRemessaLocal { get; set; }
        public virtual DbSet<TsBoletoRetornoLocal> TsBoletoRetornoLocal { get; set; }
        public virtual DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }
        public virtual DbSet<Versao> Versao { get; set; }
        public virtual DbSet<VindiBills> VindiBills { get; set; }
        public virtual DbSet<VindiCustomers> VindiCustomers { get; set; }
        public virtual DbSet<VindiPlanoContas> VindiPlanoContas { get; set; }

        // Unable to generate entity type for table 'IBGE                           '. Please see the warning messages.
        // Unable to generate entity type for table 'PRODUTO_ICMS                   '. Please see the warning messages.
        // Unable to generate entity type for table 'PRODUTO_REGRA_TRIBUTARIA       '. Please see the warning messages.
        // Unable to generate entity type for table 'PRODUTO_GRUPO_REGRA_TRIBUTARIA '. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseFirebird("character set=UTF8;data source=127.0.0.1;initial catalog=Infofisco_sist_teste;port number=3050;user id=sysdba;password=masterkey");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalistaFornecedor>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ANALISTA_FORNECEDOR");

                entity.Property(e => e.CodigoProduto).HasDefaultValueSql("DEFAULT 'P'");
            });

            modelBuilder.Entity<AnalistaIbptCfop>(entity =>
            {
                entity.HasKey(e => e.Ccfop)
                    .HasName("PK_CFOP_2");

                entity.HasIndex(e => e.Ccfop)
                    .HasName("PK_CFOP_2");
            });

            modelBuilder.Entity<AnalistaTributacao>(entity =>
            {
                entity.HasKey(e => e.IdTributacao)
                    .HasName("PK_ANALISTA_TRIBUTACAO");

                entity.HasIndex(e => e.CodCtaDespesa)
                    .HasName("FK_ANALISTA_TRIBUTACAO_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodCtaReceita)
                    .HasName("FK_ANALISTA_TRIBUTACAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.IdTributacao)
                    .HasName("PK_ANALISTA_TRIBUTACAO");
            });

            modelBuilder.Entity<AuxRega100>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_AUX_REGA100");
            });

            modelBuilder.Entity<AuxRegc100>(entity =>
            {
                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_AUX_REGC100_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_AUX_REGC100");
            });

            modelBuilder.Entity<AuxRegc101>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_AUX_REGC101");
            });

            modelBuilder.Entity<AuxRegc110>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CodInf })
                    .HasName("PK_AUX_REGC110");

                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_AUX_REGC110_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_AUX_REGC110_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodInf, e.Id })
                    .HasName("PK_AUX_REGC110");
            });

            modelBuilder.Entity<AuxRegc120>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CodDocImp, e.NumDocImp })
                    .HasName("PK_AUX_REGC120");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_AUX_REGC120")
                    .IsUnique();

                entity.HasIndex(e => e.NumAcdraw)
                    .HasName("UK_AUX_REGC120_01");

                entity.HasIndex(e => new { e.CodDocImp, e.Id, e.NumDocImp })
                    .HasName("PK_AUX_REGC120");
            });

            modelBuilder.Entity<AuxRegc140>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_AUX_REGC140");
            });

            modelBuilder.Entity<AuxRegc141>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumParc })
                    .HasName("PK_AUX_REGC141");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_AUX_REGC141_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumParc })
                    .HasName("PK_AUX_REGC141");
            });

            modelBuilder.Entity<AuxRegc170>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumItem })
                    .HasName("PK_AUX_REGC170");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_AUX_REGC170_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("PK_AUX_REGC170");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.NumBanco)
                    .HasName("PK_BANCO");

                entity.HasIndex(e => e.NumBanco)
                    .HasName("PK_BANCO");
            });

            modelBuilder.Entity<BlocoVii>(entity =>
            {
                entity.HasKey(e => e.Tabela)
                    .HasName("PK_BLOCO_VII");

                entity.HasIndex(e => e.Tabela)
                    .HasName("PK_BLOCO_VII");
            });

            modelBuilder.Entity<Cancelamento>(entity =>
            {
                entity.HasKey(e => new { e.Chnfe, e.Tpamb })
                    .HasName("PK_CANCELAMENTO");

                entity.HasIndex(e => new { e.Chnfe, e.Tpamb })
                    .HasName("PK_CANCELAMENTO");
            });

            modelBuilder.Entity<CapptaOperacaoAprovada>(entity =>
            {
                entity.HasKey(e => e.NsuTef)
                    .HasName("PK_CAPPTA_OPERACAO_APROVADA");

                entity.HasIndex(e => e.NsuTef)
                    .HasName("PK_CAPPTA_OPERACAO_APROVADA");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CARGO");
            });

            modelBuilder.Entity<CentroCustoLucro>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CENTROCUSTO");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_CENTRO_CUSTO_LUCRO_01")
                    .IsUnique();

                entity.Property(e => e.Indice).HasDefaultValueSql("Default 0");
            });

            modelBuilder.Entity<Cfop>(entity =>
            {
                entity.HasKey(e => e.Ccfop)
                    .HasName("PK_CFOP");

                entity.HasIndex(e => e.Ccfop)
                    .HasName("PK_CFOP");
            });

            modelBuilder.Entity<Clausula>(entity =>
            {
                entity.HasKey(e => new { e.PropostaId, e.NumeroClausula })
                    .HasName("PK_CLAUSULA");

                entity.HasIndex(e => e.PropostaId)
                    .HasName("FK_CLAUSULA_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.NumeroClausula, e.PropostaId })
                    .HasName("PK_CLAUSULA");
            });

            modelBuilder.Entity<CleanWheyVendas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_CLEAN_WHEY_VENDAS");

                entity.HasIndex(e => e.NotafiscalId)
                    .HasName("FK_CLEAN_WHEY_VENDAS_01")
                    .IsUnique();

                entity.HasIndex(e => e.Numero)
                    .HasName("PK_CLEAN_WHEY_VENDAS");
            });

            modelBuilder.Entity<Composicao>(entity =>
            {
                entity.HasIndex(e => e.CprodComposto)
                    .HasName("FK_COMPOSICAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.CprodRef)
                    .HasName("FK_COMPOSICAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY8");
            });

            modelBuilder.Entity<ComposicaoGrade>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_COMPOSICAO_GRADE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_COMPOSICAO_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_COMPOSICAO_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_COMPOSICAO_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_COMPOSICAO_GRADE");
            });

            modelBuilder.Entity<Configuracao>(entity =>
            {
                entity.HasKey(e => e.Chave)
                    .HasName("PK_CONFIGURACAO");

                entity.HasIndex(e => e.Chave)
                    .HasName("PK_CONFIGURACAO");
            });

            modelBuilder.Entity<ConfiguracaoBoleto>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CONFIGURACAO_BOLETO");
            });

            modelBuilder.Entity<ConfiguracaoUsuario>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CONFIGURACAO_USUARIO");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_CONFIGURACAO_USUARIO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<ContaCapital>(entity =>
            {
                entity.HasIndex(e => e.BancoId)
                    .HasName("FK_CONTA_CAPITAL_03")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_CONTA_CAPITAL");

                entity.HasIndex(e => e.MoedaId)
                    .HasName("FK_CONTA_CAPITAL_02")
                    .IsUnique();

                entity.HasIndex(e => e.TipoContaId)
                    .HasName("FK_CONTA_CAPITAL_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Contabilista>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CONTABILISTA");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PessoaId })
                    .HasName("PK_CONTATO");

                entity.HasIndex(e => e.CargoId)
                    .HasName("FK_CONTATO_03")
                    .IsUnique();

                entity.HasIndex(e => e.DepartamentoId)
                    .HasName("FK_CONTATO_02")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_CONTATO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.PessoaId })
                    .HasName("PK_CONTATO");
            });

            modelBuilder.Entity<Cte>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE");

                entity.HasIndex(e => new { e.Nct, e.Serie, e.Tpamb })
                    .HasName("UK_CTE_01");

                entity.Property(e => e.DacteImpresso).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.Vrec).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.Vtprest).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<CteCancelamento>(entity =>
            {
                entity.HasKey(e => new { e.Chcte, e.Tpamb })
                    .HasName("PK_CTE_CANCELAMENTO");

                entity.HasIndex(e => new { e.Chcte, e.Tpamb })
                    .HasName("PK_CTE_CANCELAMENTO");
            });

            modelBuilder.Entity<CteEscritaIcms>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Tributo })
                    .HasName("PK_CTE_ESCRITA_ICMS");

                entity.HasIndex(e => e.EscritaCodCta)
                    .HasName("FK_CTE_ESCRITA_ICMS_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Numero, e.Tributo })
                    .HasName("PK_CTE_ESCRITA_ICMS");
            });

            modelBuilder.Entity<CteEscritaPisCofins>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Tributo })
                    .HasName("PK_CTE_ESCRITA_PIS_COFINS");

                entity.HasIndex(e => e.EscritaCodCta)
                    .HasName("FK_CTE_ESCRITA_PIS_COFINS_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Numero, e.Tributo })
                    .HasName("PK_CTE_ESCRITA_PIS_COFINS");
            });

            modelBuilder.Entity<CteEvento>(entity =>
            {
                entity.HasKey(e => new { e.Chcte, e.Tpamb, e.Tpevento, e.Nseqevento })
                    .HasName("PK_CTE_EVENTO");

                entity.HasIndex(e => new { e.Chcte, e.Nseqevento, e.Tpamb, e.Tpevento })
                    .HasName("PK_CTE_EVENTO");
            });

            modelBuilder.Entity<CteInutilizacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_INUTILIZACAO");
            });

            modelBuilder.Entity<CteMatrizEscrituracao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_MATRIZ_ESCRITURACAO");
            });

            modelBuilder.Entity<CteNumeracao>(entity =>
            {
                entity.HasKey(e => new { e.Tpamb, e.Serie })
                    .HasName("PK_CTE_NUMERACAO");

                entity.HasIndex(e => new { e.Serie, e.Tpamb })
                    .HasName("PK_CTE_NUMERACAO");

                entity.Property(e => e.Nct).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<CteXmlAnulacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_ANULACAO");
            });

            modelBuilder.Entity<CteXmlCarga>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_CARGA");
            });

            modelBuilder.Entity<CteXmlComplementado>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_COMPLEMENTADO");
            });

            modelBuilder.Entity<CteXmlDestinatario>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_DESTINATARIO");
            });

            modelBuilder.Entity<CteXmlDocsNf>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_NF");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_DOCS_NF_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_NF");
            });

            modelBuilder.Entity<CteXmlDocsNfe>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_NFE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_DOCS_NFE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_NFE");
            });

            modelBuilder.Entity<CteXmlDocsOutros>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_OUTROS");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_DOCS_OUTROS_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_DOCS_OUTROS");
            });

            modelBuilder.Entity<CteXmlExpedidor>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_EXPEDIDOR");
            });

            modelBuilder.Entity<CteXmlImposto>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_IMPOSTO");
            });

            modelBuilder.Entity<CteXmlRecebedor>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_RECEBEDOR");
            });

            modelBuilder.Entity<CteXmlRemetente>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_REMETENTE");
            });

            modelBuilder.Entity<CteXmlRodoMotorista>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_MOTORISTA");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_RODO_MOTORISTA_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_MOTORISTA");
            });

            modelBuilder.Entity<CteXmlRodoValePedagio>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_VALE_PEDAGIO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_RODO_VALE_PEDAGIO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_VALE_PEDAGIO");
            });

            modelBuilder.Entity<CteXmlRodoVeiculo>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_VEICULO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_RODO_VEICULO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_RODO_VEICULO");
            });

            modelBuilder.Entity<CteXmlSeguro>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_SEGURO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_CTE_XML_SEGURO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_CTE_XML_SEGURO");
            });

            modelBuilder.Entity<CteXmlSubstituicao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_SUBSTITUICAO");
            });

            modelBuilder.Entity<CteXmlTomador>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_CTE_XML_TOMADOR");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_DEPARTAMENTO");
            });

            modelBuilder.Entity<E1>(entity =>
            {
                entity.HasKey(e => e.Cnpj)
                    .HasName("PK_E1");

                entity.HasIndex(e => e.Cnpj)
                    .HasName("PK_E1");
            });

            modelBuilder.Entity<E2>(entity =>
            {
                entity.HasKey(e => new { e.CodigoProduto, e.Cnpj })
                    .HasName("PK_E2");

                entity.HasIndex(e => new { e.Cnpj, e.CodigoProduto })
                    .HasName("PK_E2");
            });

            modelBuilder.Entity<Emitente>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_EMITENTE");
            });

            modelBuilder.Entity<Empenho>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_EMPENHO");

                entity.HasIndex(e => e.Numero)
                    .HasName("PK_EMPENHO");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_EMPENHO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<EmpenhoItem>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Empenho })
                    .HasName("PK_EMPENHO_ITEM");

                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_EMPENHO_ITEM_02")
                    .IsUnique();

                entity.HasIndex(e => e.Empenho)
                    .HasName("FK_EMPENHO_ITEM_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Empenho, e.Id })
                    .HasName("PK_EMPENHO_ITEM");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.Cendereco)
                    .HasName("PK_LOCAL");

                entity.HasIndex(e => e.Cendereco)
                    .HasName("PK_LOCAL");

                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("IX_LOCAL_01")
                    .IsUnique();

                entity.HasIndex(e => e.Ctipo)
                    .HasName("IX_LOCAL_02")
                    .IsUnique();
            });

            modelBuilder.Entity<EnderecoCobranca>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ENDERECO_COBRANCA");
            });

            modelBuilder.Entity<EquivalenciaProduto>(entity =>
            {
                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_EQUIVALENCIA_PRODUTO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY9");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_EQUIVALENCIA_PRODUTO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_ESTOQUE_04")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE");

                entity.HasIndex(e => e.IdRef)
                    .HasName("FK_ESTOQUE_01")
                    .IsUnique();

                entity.HasIndex(e => e.Local)
                    .HasName("FK_ESTOQUE_02")
                    .IsUnique();

                entity.HasIndex(e => e.PedidoId)
                    .HasName("FK_ESTOQUE_05")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_ESTOQUE_03")
                    .IsUnique();
            });

            modelBuilder.Entity<EstoqueLocal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_LOCAL");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_ESTOQUE_LOCAL_01")
                    .IsUnique();

                entity.Property(e => e.Indice).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<EstoqueMovimentacao>(entity =>
            {
                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_ESTOQUE_MOVIMENTACAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_MOVIMENTACAO");

                entity.HasIndex(e => e.LocalId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_11")
                    .IsUnique();

                entity.HasIndex(e => e.MovimentacaoReferenciaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.OperacaoId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_06")
                    .IsUnique();

                entity.HasIndex(e => e.PdvVendaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_05")
                    .IsUnique();

                entity.HasIndex(e => e.PedidoId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_04")
                    .IsUnique();

                entity.HasIndex(e => e.ProducaoProcessoId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_08")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoLoteId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_10")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoSubstituidoCodigo)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_09")
                    .IsUnique();

                entity.HasIndex(e => e.PropriedadePessoaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_07")
                    .IsUnique();

                entity.HasIndex(e => e.ReservaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_03")
                    .IsUnique();

                entity.Property(e => e.LocalId).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<EstoqueMovimentacaoCfe>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_CFE");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_CFE_02")
                    .IsUnique();

                entity.Property(e => e.EmitenteIndicador).HasDefaultValueSql("DEFAULT '0'");
            });

            modelBuilder.Entity<EstoqueMovimentacaoEcf>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_ECF");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_ECF_02")
                    .IsUnique();

                entity.Property(e => e.EmitenteIndicador).HasDefaultValueSql("DEFAULT '0'");
            });

            modelBuilder.Entity<EstoqueMovimentacaoFiscal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_FISCAL");
            });

            modelBuilder.Entity<EstoqueMovimentacaoGrade>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_GRADE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_ESTOQUE_MOV_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_ESTOQUE_MOV_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_ESTOQUE_MOV_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_GRADE");
            });

            modelBuilder.Entity<EstoqueMovimentacaoNota>(entity =>
            {
                entity.HasIndex(e => e.Chave)
                    .HasName("IX_ESTOQUE_MOVIMENTACAO_NOTA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_NOTA");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_ESTOQUE_MOVIMENTACAO_NOTA_02")
                    .IsUnique();

                entity.Property(e => e.EmitenteIndicador).HasDefaultValueSql("DEFAULT '0'");
            });

            modelBuilder.Entity<EstoqueMovimentacaoValor>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_VALOR");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_ESTOQUE_MOV_VALOR_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_ESTOQUE_MOVIMENTACAO_VALOR");
            });

            modelBuilder.Entity<EstoqueOperacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_OPERACAO");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_ESTOQUE_OPERACAO_01")
                    .IsUnique();

                entity.Property(e => e.Indice).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.Padrao).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<EstoqueReposicao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_REPOSICAO");

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_ESTOQUE_REPOSICAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.PropriedadePessoaId)
                    .HasName("FK_ESTOQUE_REPOSICAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_ESTOQUE_REPOSICAO_03")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_ESTOQUE_REPOSICAO_04")
                    .IsUnique();

                entity.Property(e => e.PontoReposicao).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.QtdMax).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.QtdMin).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<EstoqueReserva>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ESTOQUE_RESERVA");

                entity.HasIndex(e => e.InteressadoPessoaId)
                    .HasName("FK_ESTOQUE_RESERVA_02")
                    .IsUnique();

                entity.HasIndex(e => e.ProducaoProcessoId)
                    .HasName("FK_ESTOQUE_RESERVA_01")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_ESTOQUE_RESERVA_04")
                    .IsUnique();

                entity.HasIndex(e => e.PropriedadePessoaId)
                    .HasName("FK_ESTOQUE_RESERVA_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemPedidoId, e.PedidoId })
                    .HasName("FK_ESTOQUE_RESERVA_05")
                    .IsUnique();
            });

            modelBuilder.Entity<EstoqueReservaGrade>(entity =>
            {
                entity.HasKey(e => new { e.ReservaId, e.Id })
                    .HasName("PK_ESTOQUE_RESERVA_GRADE");

                entity.HasIndex(e => e.ReservaId)
                    .HasName("FK_ESTOQUE_RESERVA_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_ESTOQUE_RESERVA_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_ESTOQUE_RESERVA_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.ReservaId })
                    .HasName("PK_ESTOQUE_RESERVA_GRADE");
            });

            modelBuilder.Entity<Eventocancnfe>(entity =>
            {
                entity.HasKey(e => new { e.Chnfe, e.Tpamb })
                    .HasName("PK_EVENTOCANCNFE");

                entity.HasIndex(e => new { e.Chnfe, e.Tpamb })
                    .HasName("PK_EVENTOCANCNFE");
            });

            modelBuilder.Entity<FluxoCaixa>(entity =>
            {
                entity.HasIndex(e => e.ContaCapitalId)
                    .HasName("FK_FLUXO_CAIXA_1")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_FLUXO_CAIXA");

                entity.HasIndex(e => e.LancamentoId)
                    .HasName("FK_FLUXO_CAIXA_2")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_FLUXO_CAIXA_4")
                    .IsUnique();

                entity.HasIndex(e => e.PlanoContaId)
                    .HasName("FK_FLUXO_CAIXA_3")
                    .IsUnique();
            });

            modelBuilder.Entity<FormaPagamento>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_FORMA_PAGAMENTO");
            });

            modelBuilder.Entity<Funcionalidade>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_FUNCIONALIDADE");

                entity.HasIndex(e => e.ModuloId)
                    .HasName("IX_FUNCIONALIDADE_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasIndex(e => e.EixoXId)
                    .HasName("FK_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.EixoYId)
                    .HasName("FK_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_GRADE");
            });

            modelBuilder.Entity<GradeEixo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_GRADE_EIXO");
            });

            modelBuilder.Entity<GradeEixoItem>(entity =>
            {
                entity.HasIndex(e => e.EixoId)
                    .HasName("FK_GRADE_EIXO_ITEM_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_GRADE_EIXO_ITEM");
            });

            modelBuilder.Entity<Grupousuario>(entity =>
            {
                entity.HasIndex(e => e.Ativo)
                    .HasName("IX_GRUPO_USUARIO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_GRUPO_USUARIO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_GRUPOUSUARIO");
            });

            modelBuilder.Entity<Icms>(entity =>
            {
                entity.HasKey(e => new { e.UfOrigem, e.UfDestino })
                    .HasName("PK_ICMS");

                entity.HasIndex(e => new { e.UfDestino, e.UfOrigem })
                    .HasName("PK_ICMS");
            });

            modelBuilder.Entity<InfonfseContaReceber>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_INFONFSE_CONTA_RECEBER");

                entity.HasIndex(e => new { e.RpsNumero, e.RpsSerie, e.RpsTipo })
                    .HasName("UK_INFONFSE_CONTA_RECEBER_01");
            });

            modelBuilder.Entity<InfonfsePlanoContas>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_INFONFSE_PLANO_CONTAS");
            });

            modelBuilder.Entity<InstrucaoBoleto>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.IdBoleto })
                    .HasName("PK_INSTRUCAO_BOLETO");

                entity.HasIndex(e => e.IdBoleto)
                    .HasName("FK_INSTRUCAO_BOLETO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdBoleto, e.Numero })
                    .HasName("PK_INSTRUCAO_BOLETO");
            });

            modelBuilder.Entity<ItemOrcamento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrcamentoId })
                    .HasName("PK_ITEM_ORCAMENTO");

                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_ITEM_ORCAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.OrcamentoId)
                    .HasName("FK_ITEM_ORCAMENTO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.OrcamentoId })
                    .HasName("PK_ITEM_ORCAMENTO");
            });

            modelBuilder.Entity<ItemPedido>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PedidoId })
                    .HasName("PK_ITEM_PEDIDO");

                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_ITEM_PEDIDO_01")
                    .IsUnique();

                entity.HasIndex(e => e.PedidoId)
                    .HasName("FK_ITEM_PEDIDO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.PedidoId })
                    .HasName("PK_ITEM_PEDIDO");
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.HasIndex(e => e.ContaCapitalId)
                    .HasName("FK_LANCAMENTO_04")
                    .IsUnique();

                entity.HasIndex(e => e.CteId)
                    .HasName("FK_LANCAMENTO_09")
                    .IsUnique();

                entity.HasIndex(e => e.FormaPagamentoId)
                    .HasName("FK_LANCAMENTO_03")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_LANCAMENTO");

                entity.HasIndex(e => e.MoedaId)
                    .HasName("FK_LANCAMENTO_05")
                    .IsUnique();

                entity.HasIndex(e => e.NotafiscalId)
                    .HasName("FK_LANCAMENTO_08")
                    .IsUnique();

                entity.HasIndex(e => e.PedidoId)
                    .HasName("FK_LANCAMENTO_07")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_LANCAMENTO_06")
                    .IsUnique();

                entity.HasIndex(e => e.PlanoContasId)
                    .HasName("FK_LANCAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.TipoDocumentoFinanceiroId)
                    .HasName("FK_LANCAMENTO_02")
                    .IsUnique();
            });

            modelBuilder.Entity<LocalArmazenagem>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("LOCAL_ARMAZENAGEM01_INDEX01");
            });

            modelBuilder.Entity<MatrizDespesas>(entity =>
            {
                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_MATRIZ_DESPESAS_02")
                    .IsUnique();

                entity.HasIndex(e => e.EscritaCodItem)
                    .HasName("FK_MATRIZ_DESPESAS_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_MATRIZ_DESPESAS");
            });

            modelBuilder.Entity<MatrizEscrituracao>(entity =>
            {
                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_MATRIZ_ESCRITURACAO_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_MATRIZ_ESCRITURACAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.GrupoItem)
                    .HasName("FK_MATRIZ_ESCRITURACAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_MATRIZ_ESCRITURACAO");
            });

            modelBuilder.Entity<Mdfe>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_MDFE");

                entity.HasIndex(e => new { e.Nmdf, e.Serie, e.Tpamb })
                    .HasName("UK_MDFE_01");
            });

            modelBuilder.Entity<MdfeEvento>(entity =>
            {
                entity.HasKey(e => new { e.Chmdfe, e.Tpamb, e.Tpevento, e.Nseqevento })
                    .HasName("PK_MDFE_EVENTO");

                entity.HasIndex(e => new { e.Chmdfe, e.Nseqevento, e.Tpamb, e.Tpevento })
                    .HasName("PK_MDFE_EVENTO");
            });

            modelBuilder.Entity<MdfeNumeracao>(entity =>
            {
                entity.HasKey(e => new { e.Tpamb, e.Serie })
                    .HasName("PK_MDFE_NUMERACAO");

                entity.HasIndex(e => new { e.Serie, e.Tpamb })
                    .HasName("PK_MDFE_NUMERACAO");

                entity.Property(e => e.Nmdf).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<MdfeXmlCondutor>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Cpf })
                    .HasName("PK_MDFE_XML_CONDUTOR");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_CONDUTOR_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cpf, e.Id })
                    .HasName("PK_MDFE_XML_CONDUTOR");
            });

            modelBuilder.Entity<MdfeXmlCte>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Cmundescarga, e.Chcte })
                    .HasName("PK_MDFE_XML_CTE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_CTE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cmundescarga, e.Chcte, e.Id })
                    .HasName("PK_MDFE_XML_CTE");
            });

            modelBuilder.Entity<MdfeXmlInfmuncarrega>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Cmuncarrega })
                    .HasName("PK_MDFE_XML_INFMUNCARREGA");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_INFMUNCARREGA_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cmuncarrega, e.Id })
                    .HasName("PK_MDFE_XML_INFMUNCARREGA");
            });

            modelBuilder.Entity<MdfeXmlNfe>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Cmundescarga, e.Chnfe })
                    .HasName("PK_MDFE_XML_NFE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_NFE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cmundescarga, e.Chnfe, e.Id })
                    .HasName("PK_MDFE_XML_NFE");
            });

            modelBuilder.Entity<MdfeXmlRodoCiot>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_MDFE_XML_RODO_CIOT");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_RODO_CIOT")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_MDFE_XML_RODO_CIOT");
            });

            modelBuilder.Entity<MdfeXmlRodoContratante>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_MDFE_XML_RODO_CONTRATANTE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_RODO_CONTRATANTE")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_MDFE_XML_RODO_CONTRATANTE");
            });

            modelBuilder.Entity<MdfeXmlRodoValePedagio>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_MDFE_XML_RODO_VALE_PEDAGIO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_RODO_VALE_PEDAGIO")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_MDFE_XML_RODO_VALE_PEDAGIO");
            });

            modelBuilder.Entity<MdfeXmlSeguro>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_MDFE_XML_SEGURO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_SEGURO")
                    .IsUnique();

                entity.HasIndex(e => e.Numero)
                    .HasName("PK_MDFE_XML_SEGURO");
            });

            modelBuilder.Entity<MdfeXmlSeguroAverbacao>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_MDFE_XML_SEGURO_AVERBACAO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_SEGURO_AVERBACAO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_MDFE_XML_SEGURO_AVERBACAO");
            });

            modelBuilder.Entity<MdfeXmlVeictracao>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Placa })
                    .HasName("PK_MDFE_XML_VEICTRACAO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_MDFE_XML_VEICTRACAO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Placa })
                    .HasName("PK_MDFE_XML_VEICTRACAO");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_MODULO");
            });

            modelBuilder.Entity<Moeda>(entity =>
            {
                entity.HasKey(e => e.Sigla)
                    .HasName("PK_MOEDA");

                entity.HasIndex(e => e.Sigla)
                    .HasName("PK_MOEDA");
            });

            modelBuilder.Entity<NcmCest>(entity =>
            {
                entity.HasKey(e => e.Ncm)
                    .HasName("PK_NCM_CEST");

                entity.HasIndex(e => e.Cest)
                    .HasName("IX_NCM_CEST_01")
                    .IsUnique();

                entity.HasIndex(e => e.Ncm)
                    .HasName("PK_NCM_CEST");

                entity.HasIndex(e => e.ProdutoGrupoId)
                    .HasName("IX_NCM_CEST_02")
                    .IsUnique();
            });

            modelBuilder.Entity<Notafiscal>(entity =>
            {
                entity.HasIndex(e => e.Chnfe)
                    .HasName("IX_NOTAFISCAL_04")
                    .IsUnique();

                entity.HasIndex(e => e.Cstat)
                    .HasName("IX_NOTAFISCAL_01")
                    .IsUnique();

                entity.HasIndex(e => e.Dhemi)
                    .HasName("IX_NOTAFISCAL_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL");

                entity.HasIndex(e => e.PedidoId)
                    .HasName("FK_NOTAFISCAL_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Mod, e.Tpamb })
                    .HasName("IX_NOTAFISCAL_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Mod, e.Nnf, e.Serie, e.Tpamb })
                    .HasName("UK_NOTAFISCAL_01");

                entity.Property(e => e.Danfeimpresso).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<NotafiscalEscritaCofins>(entity =>
            {
                entity.HasKey(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_COFINS");

                entity.HasIndex(e => e.CondicaoCodPart)
                    .HasName("FK_NF_ESCRITA_COFINS_01")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoCodigo)
                    .HasName("FK_NF_ESCRITA_COFINS_02")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoGrupo)
                    .HasName("FK_NF_ESCRITA_COFINS_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_COFINS");
            });

            modelBuilder.Entity<NotafiscalEscritaIcms>(entity =>
            {
                entity.HasKey(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_ICMS");

                entity.HasIndex(e => e.CondicaoCodPart)
                    .HasName("FK_NF_ESCRITA_ICMS_01")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoCodigo)
                    .HasName("FK_NF_ESCRITA_ICMS_02")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoGrupo)
                    .HasName("FK_NF_ESCRITA_ICMS_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_ICMS");
            });

            modelBuilder.Entity<NotafiscalEscritaIpi>(entity =>
            {
                entity.HasKey(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_IPI");

                entity.HasIndex(e => e.CondicaoCodPart)
                    .HasName("FK_NF_ESCRITA_IPI_01")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoCodigo)
                    .HasName("FK_NF_ESCRITA_IPI_02")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoGrupo)
                    .HasName("FK_NF_ESCRITA_IPI_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_IPI");
            });

            modelBuilder.Entity<NotafiscalEscritaOperacao>(entity =>
            {
                entity.HasKey(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_OPERACAO");

                entity.HasIndex(e => e.CondicaoCodPart)
                    .HasName("FK_NF_ESCRITA_OPERACAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoCodigo)
                    .HasName("FK_NF_ESCRITA_OPERACAO_02")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoGrupo)
                    .HasName("FK_NF_ESCRITA_OPERACAO_03")
                    .IsUnique();

                entity.HasIndex(e => e.EscritaCodCta)
                    .HasName("FK_NF_ESCRITA_OPERACAO_04")
                    .IsUnique();

                entity.HasIndex(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_OPERACAO");
            });

            modelBuilder.Entity<NotafiscalEscritaPis>(entity =>
            {
                entity.HasKey(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_PIS");

                entity.HasIndex(e => e.CondicaoCodPart)
                    .HasName("FK_NF_ESCRITA_PIS_01")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoCodigo)
                    .HasName("FK_NF_ESCRITA_PIS_02")
                    .IsUnique();

                entity.HasIndex(e => e.CondicaoProdutoGrupo)
                    .HasName("FK_NF_ESCRITA_PIS_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.CondicaoCodMod, e.Id })
                    .HasName("PK_NF_ESCRITA_PIS");
            });

            modelBuilder.Entity<NotafiscalEvento>(entity =>
            {
                entity.HasKey(e => new { e.Chnfe, e.Tpamb, e.Tpevento, e.Nseqevento })
                    .HasName("PK_NOTAFISCAL_EVENTO");

                entity.HasIndex(e => new { e.Chnfe, e.Nseqevento, e.Tpamb, e.Tpevento })
                    .HasName("PK_NOTAFISCAL_EVENTO");
            });

            modelBuilder.Entity<NotafiscalInterface>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_INTERFACE");
            });

            modelBuilder.Entity<NotafiscalInterfaceParametro>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_NF_INTERFACE_PARAMETRO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NF_INTERFACE_PARAMETRO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_NF_INTERFACE_PARAMETRO");
            });

            modelBuilder.Entity<NotafiscalInutilizacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_INUTILIZACAO");
            });

            modelBuilder.Entity<NotafiscalNumeracao>(entity =>
            {
                entity.HasKey(e => new { e.Tpamb, e.Mod, e.Serie })
                    .HasName("PK_NOTAFISCAL_NUMERACAO");

                entity.HasIndex(e => new { e.Mod, e.Serie, e.Tpamb })
                    .HasName("PK_NOTAFISCAL_NUMERACAO");
            });

            modelBuilder.Entity<NotafiscalOperacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_OPERACAO");

                entity.Property(e => e.IndicadorIbpt).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<NotafiscalTributacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_TRIBUTACAO");

                entity.Property(e => e.IndicadorProdutoServico).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<NotafiscalTributacaoEstadual>(entity =>
            {
                entity.HasKey(e => new { e.Uf, e.Id })
                    .HasName("PK_NF_TRIBUTACAO_ESTADUAL");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NF_TRIBUTACAO_ESTADUAL_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Uf })
                    .HasName("PK_NF_TRIBUTACAO_ESTADUAL");

                entity.Property(e => e.IcmsIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.IcmsufdestIndicador).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<NotafiscalTributacaoFederal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_TRIBUTACAO_FEDERAL");

                entity.Property(e => e.CofinsIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.CofinsstIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.IiIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.IpiIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.PisIndicador).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.PisstIndicador).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<NotafiscalTributacaoGrupo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_TRIBUTACAO_GRUPO");

                entity.HasIndex(e => e.NotafiscalOperacaoId)
                    .HasName("FK_NF_TRIBUTACAO_GRUPO_02")
                    .IsUnique();

                entity.HasIndex(e => e.NotafiscalTributacaoId)
                    .HasName("FK_NF_TRIBUTACAO_GRUPO_03")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoGrupoId)
                    .HasName("FK_NF_TRIBUTACAO_GRUPO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<NotafiscalTributacaoProduto>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_TRIBUTACAO_PRODUTO");

                entity.HasIndex(e => e.NotafiscalOperacaoId)
                    .HasName("FK_NF_TRIBUTACAO_PRODUTO_02")
                    .IsUnique();

                entity.HasIndex(e => e.NotafiscalTributacaoId)
                    .HasName("FK_NF_TRIBUTACAO_PRODUTO_03")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_NF_TRIBUTACAO_PRODUTO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<NotafiscalXmlCobrDup>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_NF_XML_COBR_DUP");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NF_COBR_DUP_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_NF_XML_COBR_DUP");
            });

            modelBuilder.Entity<NotafiscalXmlCobrFat>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NF_XML_COBR_FAT");
            });

            modelBuilder.Entity<NotafiscalXmlCompra>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_COMPRA");
            });

            modelBuilder.Entity<NotafiscalXmlDest>(entity =>
            {
                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("IX_NOTAFISCAL_XML_DEST_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_DEST");

                entity.HasIndex(e => e.Xnome)
                    .HasName("IX_NOTAFISCAL_XML_DEST_02")
                    .IsUnique();
            });

            modelBuilder.Entity<NotafiscalXmlDet>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Nitem })
                    .HasName("PK_NOTAFISCAL_XML_DET");

                entity.HasIndex(e => e.Cprod)
                    .HasName("IX_NOTAFISCAL_XML_DET_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_DET_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Nitem })
                    .HasName("PK_NOTAFISCAL_XML_DET");
            });

            modelBuilder.Entity<NotafiscalXmlDetImposto>(entity =>
            {
                entity.HasKey(e => new { e.Nitem, e.Id })
                    .HasName("PK_NF_XML_DET_IMPOSTO");

                entity.HasIndex(e => new { e.Id, e.Nitem })
                    .HasName("PK_NF_XML_DET_IMPOSTO");
            });

            modelBuilder.Entity<NotafiscalXmlDetImpostodevol>(entity =>
            {
                entity.HasKey(e => new { e.Nitem, e.Id })
                    .HasName("PK_NF_XML_DET_IMPOSTODEVOL");

                entity.HasIndex(e => new { e.Id, e.Nitem })
                    .HasName("PK_NF_XML_DET_IMPOSTODEVOL");
            });

            modelBuilder.Entity<NotafiscalXmlEntrega>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_ENTREGA");
            });

            modelBuilder.Entity<NotafiscalXmlIcmstot>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_ICMSTOT");
            });

            modelBuilder.Entity<NotafiscalXmlInfadicObscont>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_NF_XML_INFADIC_OBSCONT");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NF_INFADIC_OBSCONT_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_NF_XML_INFADIC_OBSCONT");
            });

            modelBuilder.Entity<NotafiscalXmlIssqntot>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_ISSQNTOT");
            });

            modelBuilder.Entity<NotafiscalXmlPagDetpag>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_NF_XML_PAG_DETPAG");

                entity.HasIndex(e => e.DetpagTpag)
                    .HasName("IX_NF_XML_PAG_DETPAG_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NF_XML_PAG_DETPAG_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_NF_XML_PAG_DETPAG");
            });

            modelBuilder.Entity<NotafiscalXmlRefcte>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("NOTAFISCAL_XML_REFCTE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_REFCTE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("NOTAFISCAL_XML_REFCTE");
            });

            modelBuilder.Entity<NotafiscalXmlRefecf>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("NOTAFISCAL_XML_REFECF");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_REFECF_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("NOTAFISCAL_XML_REFECF");
            });

            modelBuilder.Entity<NotafiscalXmlRefnf>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("NOTAFISCAL_XML_REFNF");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_REFNF_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("NOTAFISCAL_XML_REFNF");
            });

            modelBuilder.Entity<NotafiscalXmlRefnfe>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("NOTAFISCAL_XML_REFNFE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_REFNFE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("NOTAFISCAL_XML_REFNFE");
            });

            modelBuilder.Entity<NotafiscalXmlRefnfp>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("NOTAFISCAL_XML_REFNFP");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_NOTAFISCAL_XML_REFNFP_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("NOTAFISCAL_XML_REFNFP");
            });

            modelBuilder.Entity<NotafiscalXmlRetirada>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_RETIRADA");
            });

            modelBuilder.Entity<NotafiscalXmlRettrib>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_RETTRIB");
            });

            modelBuilder.Entity<NotafiscalXmlTransp>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_NOTAFISCAL_XML_TRANSP");
            });

            modelBuilder.Entity<Observacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_OBSERVACAO");
            });

            modelBuilder.Entity<Operacao>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.FuncionalidadeId })
                    .HasName("PK_OPERACAO");

                entity.HasIndex(e => e.FuncionalidadeId)
                    .HasName("IX_OPERACAO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.FuncionalidadeId, e.Id })
                    .HasName("PK_OPERACAO");
            });

            modelBuilder.Entity<Orcamento>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_ORCAMENTO");

                entity.HasIndex(e => e.MoedaId)
                    .HasName("FK_ORCAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_ORCAMENTO_03")
                    .IsUnique();

                entity.HasIndex(e => e.VendedorId)
                    .HasName("FK_ORCAMENTO_02")
                    .IsUnique();
            });

            modelBuilder.Entity<OrcamentoItemGrade>(entity =>
            {
                entity.HasKey(e => new { e.ItemOrcamentoId, e.OrcamentoId, e.Id })
                    .HasName("PK_ORCAMENTO_ITEM_GRADE");

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_ORCAMENTO_ITEM_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_ORCAMENTO_ITEM_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemOrcamentoId, e.OrcamentoId })
                    .HasName("FK_ORCAMENTO_ITEM_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.ItemOrcamentoId, e.OrcamentoId })
                    .HasName("PK_ORCAMENTO_ITEM_GRADE");
            });

            modelBuilder.Entity<PagadoraBeneficiaria>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PAGADORA_BENEFICIARIA");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.Cpais)
                    .HasName("PK_PAIS");

                entity.HasIndex(e => e.Cpais)
                    .HasName("PK_PAIS");
            });

            modelBuilder.Entity<Pdv>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PDV");

                entity.HasIndex(e => e.Maquina)
                    .HasName("UK_PDV_01");
            });

            modelBuilder.Entity<PdvAbertura>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_ABERTURA");

                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_ABERTURA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_ABERTURA_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_ABERTURA");

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvFechamento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_FECHAMENTO");

                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_FECHAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_FECHAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_FECHAMENTO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_FECHAMENTO");

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvParametro>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PDV_PARAMETRO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_PARAMETRO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_PARAMETRO");
            });

            modelBuilder.Entity<PdvSangria>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_SANGRIA");

                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_SANGRIA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_SANGRIA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_SANGRIA_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_SANGRIA");

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvSuprimento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_SUPRIMENTO");

                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_SUPRIMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_SUPRIMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_SUPRIMENTO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_SUPRIMENTO");

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvVenda>(entity =>
            {
                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_VENDA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PDV_VENDA");

                entity.HasIndex(e => e.IndicadorPresenca)
                    .HasName("IX_PDV_VENDA_02")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_VENDA_02")
                    .IsUnique();

                entity.HasIndex(e => e.PontoVenda)
                    .HasName("FK_PDV_VENDA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("IX_PDV_VENDA_03")
                    .IsUnique();

                entity.HasIndex(e => e.Vendedor)
                    .HasName("FK_PDV_VENDA_03")
                    .IsUnique();

                entity.Property(e => e.Acrescimo).HasDefaultValueSql("default 0");

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");

                entity.Property(e => e.Desconto).HasDefaultValueSql("default 0");

                entity.Property(e => e.Subtotal).HasDefaultValueSql("default 0");

                entity.Property(e => e.Total).HasDefaultValueSql("default 0");
            });

            modelBuilder.Entity<PdvVendaAutorizacao>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PDV_VENDA_AUTORIZACAO");

                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_VENDA_AUTORIZACAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_VENDA_AUTORIZACAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_VENDA_AUTORIZACAO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_AUTORIZACAO");

                entity.Property(e => e.DataHora).HasDefaultValueSql("DEFAULT CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvVendaCancelamento>(entity =>
            {
                entity.HasIndex(e => e.DataHora)
                    .HasName("IX_PDV_VENDA_CANCELAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PDV_VENDA_CANCELAMENTO");

                entity.HasIndex(e => e.Operador)
                    .HasName("FK_PDV_VENDA_CANCELAMENTO_02")
                    .IsUnique();

                entity.Property(e => e.DataHora).HasDefaultValueSql("default CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<PdvVendaCliente>(entity =>
            {
                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("IX_PDV_VENDA_CLIENTE_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PDV_VENDA_CLIENTE");

                entity.HasIndex(e => e.Idestrangeiro)
                    .HasName("IX_PDV_VENDA_CLIENTE_02")
                    .IsUnique();

                entity.HasIndex(e => e.Xnome)
                    .HasName("IX_PDV_VENDA_CLIENTE_03")
                    .IsUnique();
            });

            modelBuilder.Entity<PdvVendaItem>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_ITEM");

                entity.HasIndex(e => e.Codigo)
                    .HasName("FK_PDV_VENDA_ITEM_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_VENDA_ITEM_01")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("IX_PDV_VENDA_ITEM_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_ITEM");

                entity.Property(e => e.Acrescimo).HasDefaultValueSql("default 0");

                entity.Property(e => e.Desconto).HasDefaultValueSql("default 0");

                entity.Property(e => e.Status).HasDefaultValueSql("default 0");

                entity.Property(e => e.Subtotal).HasDefaultValueSql("default 0");

                entity.Property(e => e.Total).HasDefaultValueSql("default 0");

                entity.Property(e => e.ValorUnitario).HasDefaultValueSql("default 0");
            });

            modelBuilder.Entity<PdvVendaItemEstoque>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero, e.EstoqueId })
                    .HasName("PK_PDV_VENDA_ITEM_ESTOQUE");

                entity.HasIndex(e => e.EstoqueId)
                    .HasName("FK_PDV_VENDA_ITEM_ESTOQUE_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("FK_PDV_VENDA_ITEM_ESTOQUE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.EstoqueId, e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_ITEM_ESTOQUE");
            });

            modelBuilder.Entity<PdvVendaItemGrade>(entity =>
            {
                entity.HasKey(e => new { e.PdvVendaItemGradeNumero, e.PdvVendaItemNumero, e.PdvVendaItemId })
                    .HasName("PK_PDV_VENDA_ITEM_GRADE");

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_PDV_VENDA_ITEM_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_PDV_VENDA_ITEM_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.PdvVendaItemId, e.PdvVendaItemNumero })
                    .HasName("FK_PDV_VENDA_ITEM_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.PdvVendaItemId, e.PdvVendaItemGradeNumero, e.PdvVendaItemNumero })
                    .HasName("PK_PDV_VENDA_ITEM_GRADE");
            });

            modelBuilder.Entity<PdvVendaNotafiscal>(entity =>
            {
                entity.HasKey(e => new { e.PdvVendaId, e.NotafiscalId })
                    .HasName("PK_PDV_VENDA_NOTAFISCAL");

                entity.HasIndex(e => e.NotafiscalId)
                    .HasName("FK_PDV_VENDA_NOTAFISCAL_02")
                    .IsUnique();

                entity.HasIndex(e => e.PdvVendaId)
                    .HasName("FK_PDV_VENDA_NOTAFISCAL_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.NotafiscalId, e.PdvVendaId })
                    .HasName("PK_PDV_VENDA_NOTAFISCAL");
            });

            modelBuilder.Entity<PdvVendaPagamento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_PAGAMENTO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PDV_VENDA_PAGAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("IX_PDV_VENDA_PAGAMENTO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_PDV_VENDA_PAGAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PDV_VENDA_PAGAMENTO");
            });

            modelBuilder.Entity<PdvVendaTransporte>(entity =>
            {
                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("IX_PDV_VENDA_TRANSPORTE_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PDV_VENDA_TRANSPORTE");

                entity.HasIndex(e => e.Modfrete)
                    .HasName("IX_PDV_VENDA_TRANSPORTE_01")
                    .IsUnique();

                entity.HasIndex(e => e.Xnome)
                    .HasName("IX_PDV_VENDA_TRANSPORTE_03")
                    .IsUnique();
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasIndex(e => e.ContaCapitalId)
                    .HasName("FK_PEDIDO_06")
                    .IsUnique();

                entity.HasIndex(e => e.FormaPagamentoId)
                    .HasName("FK_PEDIDO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PEDIDO");

                entity.HasIndex(e => e.MoedaId)
                    .HasName("FK_PEDIDO_03")
                    .IsUnique();

                entity.HasIndex(e => e.OrcamentoId)
                    .HasName("FK_PEDIDO_08")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_PEDIDO_04")
                    .IsUnique();

                entity.HasIndex(e => e.PlanoContasId)
                    .HasName("FK_PEDIDO_05")
                    .IsUnique();

                entity.HasIndex(e => e.ProducaoId)
                    .HasName("FK_PEDIDO_09")
                    .IsUnique();

                entity.HasIndex(e => e.TipoDocumentoFinanceiroId)
                    .HasName("FK_PEDIDO_02")
                    .IsUnique();

                entity.HasIndex(e => e.VendedorId)
                    .HasName("FK_PEDIDO_07")
                    .IsUnique();
            });

            modelBuilder.Entity<PedidoItemGrade>(entity =>
            {
                entity.HasKey(e => new { e.ItemPedidoId, e.PedidoId, e.Id })
                    .HasName("PK_PEDIDO_ITEM_GRADE");

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_PEDIDO_ITEM_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_PEDIDO_ITEM_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemPedidoId, e.PedidoId })
                    .HasName("FK_PEDIDO_ITEM_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.ItemPedidoId, e.PedidoId })
                    .HasName("PK_PEDIDO_ITEM_GRADE");
            });

            modelBuilder.Entity<PedidoPagamento>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PEDIDO_PAGAMENTO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PEDIDO_PAGAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PEDIDO_PAGAMENTO");
            });

            modelBuilder.Entity<Permissao>(entity =>
            {
                entity.HasKey(e => new { e.OperacaoId, e.FuncionalidadeId, e.GrupousuarioId })
                    .HasName("PK_PERMISSAO");

                entity.HasIndex(e => e.GrupousuarioId)
                    .HasName("IX_PERMISSAO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.FuncionalidadeId, e.OperacaoId })
                    .HasName("IX_PERMISSAO_02")
                    .IsUnique();

                entity.HasIndex(e => new { e.FuncionalidadeId, e.GrupousuarioId, e.OperacaoId })
                    .HasName("PK_PERMISSAO");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("IX_PESSOA_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PESSOA");

                entity.HasIndex(e => e.Xnome)
                    .HasName("IX_PESSOA_02")
                    .IsUnique();

                entity.Property(e => e.StatusPessoa).HasDefaultValueSql("default 1");
            });

            modelBuilder.Entity<PessoaDownload>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.Cnpjcpf })
                    .HasName("PK_PESSOA_DOWNLOAD");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_PESSOA_DOWNLOAD_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cnpjcpf, e.PessoaId })
                    .HasName("PK_PESSOA_DOWNLOAD");
            });

            modelBuilder.Entity<PlanoContas>(entity =>
            {
                entity.HasIndex(e => e.FatherId)
                    .HasName("FK_PLANO_CONTAS_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PLANO_CONTAS");
            });

            modelBuilder.Entity<ProducaoClassificacao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PRODUCAO_CLASSIFICACAO");
            });

            modelBuilder.Entity<ProducaoProcesso>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PRODUCAO_PROCESSO");

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_PRODUCAO_PROCESSO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemPedidoId, e.PedidoId })
                    .HasName("FK_PRODUCAO_PROCESSO_02")
                    .IsUnique();
            });

            modelBuilder.Entity<ProducaoProcessoGrade>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PRODUCAO_PROCESSO_GRADE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PRODUCAO_PROCESSO_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_PRODUCAO_PROCESSO_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_PRODUCAO_PROCESSO_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PRODUCAO_PROCESSO_GRADE");
            });

            modelBuilder.Entity<ProducaoProcessoItem>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_PRODUCAO_PROCESSO_ITEM");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PRODUCAO_PROCESSO_ITEM_01")
                    .IsUnique();

                entity.HasIndex(e => e.Numero)
                    .HasName("PK_PRODUCAO_PROCESSO_ITEM");

                entity.HasIndex(e => e.ProdutoCodigo)
                    .HasName("FK_PRODUCAO_PROCESSO_ITEM_02")
                    .IsUnique();
            });

            modelBuilder.Entity<ProducaoProcessoItemGrade>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PROD_PROC_ITEM_GRADE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PROD_PROC_ITEM_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_PROD_PROC_ITEM_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_PROD_PROC_ITEM_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PROD_PROC_ITEM_GRADE");
            });

            modelBuilder.Entity<ProducaoRecurso>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_PRODUCAO_RECURSO");

                entity.HasIndex(e => e.ClassificacaoId)
                    .HasName("FK_PRODUCAO_RECURSO_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_PRODUCAO_RECURSO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_PRODUCAO_RECURSO");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO");

                entity.HasIndex(e => e.GradeId)
                    .HasName("FK_PRODUTO_02")
                    .IsUnique();

                entity.HasIndex(e => e.ProdutoGrupoId)
                    .HasName("FK_PRODUTO_01")
                    .IsUnique();

                entity.Property(e => e.IndicadorLote).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<ProdutoCofins>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_COFINS");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_COFINS");
            });

            modelBuilder.Entity<ProdutoCombustivel>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_COMBUSTIVEL");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_COMBUSTIVEL");
            });

            modelBuilder.Entity<ProdutoContaContabil>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_CONTA_CONTABIL");

                entity.HasIndex(e => e.CodCtaDespesa)
                    .HasName("FK_PRODUTO_CONTA_CONTABIL_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodCtaReceita)
                    .HasName("FK_PRODUTO_CONTA_CONTABIL_02")
                    .IsUnique();

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_CONTA_CONTABIL");
            });

            modelBuilder.Entity<ProdutoConversao>(entity =>
            {
                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_PRODUTO_CONVERSAO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PRODUTO_CONVERSAO");
            });

            modelBuilder.Entity<ProdutoCredito>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_CREDITO");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_CREDITO");
            });

            modelBuilder.Entity<ProdutoGrupo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PRODUTO_GRUPO");

                entity.HasIndex(e => e.ParentId)
                    .HasName("FK_PRODUTO_GRUPO_01")
                    .IsUnique();
            });

            modelBuilder.Entity<ProdutoIpi>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_IPI");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_IPI");
            });

            modelBuilder.Entity<ProdutoLote>(entity =>
            {
                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_PRODUTO_LOTE_01")
                    .IsUnique();

                entity.HasIndex(e => e.CriacaoUsuarioId)
                    .HasName("FK_PRODUTO_LOTE_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_PRODUTO_LOTE");

                entity.HasIndex(e => e.UltimaAtualizacaoUsuarioId)
                    .HasName("FK_PRODUTO_LOTE_03")
                    .IsUnique();
            });

            modelBuilder.Entity<ProdutoPis>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_PIS");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_PIS");
            });

            modelBuilder.Entity<ProdutoReceita>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_RECEITA");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_RECEITA");
            });

            modelBuilder.Entity<ProdutoSped>(entity =>
            {
                entity.HasKey(e => e.Cprod)
                    .HasName("PK_PRODUTO_SPED");

                entity.HasIndex(e => e.Cprod)
                    .HasName("PK_PRODUTO_SPED");
            });

            modelBuilder.Entity<Proposta>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_PROPOSTA");
            });

            modelBuilder.Entity<R01>(entity =>
            {
                entity.HasKey(e => e.NumeroFabricacao)
                    .HasName("PK_R01");

                entity.HasIndex(e => e.NumeroFabricacao)
                    .HasName("PK_R01");
            });

            modelBuilder.Entity<R02>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.DataMovimento })
                    .HasName("PK_R02");

                entity.HasIndex(e => new { e.DataMovimento, e.NumeroFabricacao })
                    .HasName("PK_R02");
            });

            modelBuilder.Entity<R03>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.DataMovimento, e.TotalizadorParcial })
                    .HasName("PK_R03");

                entity.HasIndex(e => new { e.DataMovimento, e.NumeroFabricacao, e.TotalizadorParcial })
                    .HasName("PK_R03");
            });

            modelBuilder.Entity<R04>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.Ccf, e.Coo })
                    .HasName("PK_R04");

                entity.HasIndex(e => new { e.Ccf, e.Coo, e.NumeroFabricacao })
                    .HasName("PK_R04");
            });

            modelBuilder.Entity<R05>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.Ccf, e.Coo, e.NumeroItem })
                    .HasName("PK_R05");

                entity.HasIndex(e => new { e.Ccf, e.Coo, e.NumeroFabricacao, e.NumeroItem })
                    .HasName("PK_R05");
            });

            modelBuilder.Entity<R05Grade>(entity =>
            {
                entity.HasKey(e => new { e.NumeroItem, e.Coo, e.Ccf, e.NumeroFabricacao, e.Id })
                    .HasName("PK_R05_GRADE");

                entity.HasIndex(e => e.XGradeEixoItemId)
                    .HasName("FK_R05_GRADE_02")
                    .IsUnique();

                entity.HasIndex(e => e.YGradeEixoItemId)
                    .HasName("FK_R05_GRADE_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Ccf, e.Coo, e.NumeroFabricacao, e.NumeroItem })
                    .HasName("FK_R05_GRADE_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Ccf, e.Coo, e.Id, e.NumeroFabricacao, e.NumeroItem })
                    .HasName("PK_R05_GRADE");
            });

            modelBuilder.Entity<R06>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.Coo, e.DataFinalEmissao })
                    .HasName("PK_R06");

                entity.HasIndex(e => new { e.Coo, e.DataFinalEmissao, e.NumeroFabricacao })
                    .HasName("PK_R06");
            });

            modelBuilder.Entity<R07>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_R07");
            });

            modelBuilder.Entity<ReducaoZSintegra>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.DataMovimento })
                    .HasName("PK_REDUCAO_Z_SINTEGRA");

                entity.HasIndex(e => new { e.DataMovimento, e.NumeroFabricacao })
                    .HasName("PK_REDUCAO_Z_SINTEGRA");
            });

            modelBuilder.Entity<ReducaoZSped>(entity =>
            {
                entity.HasKey(e => new { e.NumeroFabricacao, e.DataMovimento })
                    .HasName("PK_REDUCAO_Z_SPED");

                entity.HasIndex(e => new { e.DataMovimento, e.NumeroFabricacao })
                    .HasName("PK_REDUCAO_Z_SPED");
            });

            modelBuilder.Entity<Reg0400>(entity =>
            {
                entity.HasKey(e => e.CodNat)
                    .HasName("PK_REG0400");

                entity.HasIndex(e => e.CodNat)
                    .HasName("PK_REG0400");
            });

            modelBuilder.Entity<Reg0450>(entity =>
            {
                entity.HasKey(e => e.CodInf)
                    .HasName("PK_REG0450");

                entity.HasIndex(e => e.CodInf)
                    .HasName("PK_REG0450");
            });

            modelBuilder.Entity<Reg0460>(entity =>
            {
                entity.HasKey(e => e.CodObs)
                    .HasName("PK_REG0460");

                entity.HasIndex(e => e.CodObs)
                    .HasName("PK_REG0460");
            });

            modelBuilder.Entity<Reg0500>(entity =>
            {
                entity.HasKey(e => e.CodCta)
                    .HasName("PK_REG0500");

                entity.HasIndex(e => e.CodCta)
                    .HasName("PK_REG0500");
            });

            modelBuilder.Entity<Reg1400>(entity =>
            {
                entity.HasIndex(e => e.CodProduto)
                    .HasName("FK_REG1400_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("REG1400");
            });

            modelBuilder.Entity<Reg1600>(entity =>
            {
                entity.HasKey(e => new { e.Ano, e.Mes, e.PessoaId })
                    .HasName("PK_REG1600");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_REG1600_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Ano, e.Mes, e.PessoaId })
                    .HasName("PK_REG1600");
            });

            modelBuilder.Entity<Reg1700>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("FK_REG1700");
            });

            modelBuilder.Entity<Reg1710>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumDocIni, e.NumDocFin })
                    .HasName("PK_REG1710");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REG1710")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumDocFin, e.NumDocIni })
                    .HasName("PK_REG1710");
            });

            modelBuilder.Entity<Rega100>(entity =>
            {
                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGA100_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY20");
            });

            modelBuilder.Entity<Rega110>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CodInf })
                    .HasName("PK_REGA110");

                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_REGA110_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGA110_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodInf, e.Id })
                    .HasName("PK_REGA110");
            });

            modelBuilder.Entity<Rega111>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumProc })
                    .HasName("PK_REGA111");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGA111_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumProc })
                    .HasName("PK_REGA111");
            });

            modelBuilder.Entity<Rega120>(entity =>
            {
                entity.HasKey(e => new { e.IdA100, e.Id })
                    .HasName("PK_REGA120");

                entity.HasIndex(e => e.IdA100)
                    .HasName("FK_REGA120_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdA100 })
                    .HasName("PK_REGA120");
            });

            modelBuilder.Entity<Rega170>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGA170");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGA170_03")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGA170_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGA170");
            });

            modelBuilder.Entity<Regb020>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("REGB020");
            });

            modelBuilder.Entity<Regb025>(entity =>
            {
                entity.HasKey(e => new { e.NumItem, e.Id })
                    .HasName("PK_REGB025");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGB025_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGB025");
            });

            modelBuilder.Entity<Regc100>(entity =>
            {
                entity.HasIndex(e => e.ChvNfe)
                    .HasName("IX_REGC100_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGC100_01")
                    .IsUnique();

                entity.HasIndex(e => e.DtDoc)
                    .HasName("IX_REGC100_03")
                    .IsUnique();

                entity.HasIndex(e => e.DtES)
                    .HasName("IX_REGC100_04")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY10");

                entity.HasIndex(e => e.IndOper)
                    .HasName("IX_REGC100_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Regc101>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGC101");
            });

            modelBuilder.Entity<Regc110>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CodInf })
                    .HasName("RDB$PRIMARY21");

                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_REGC110_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC110_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodInf, e.Id })
                    .HasName("RDB$PRIMARY21");
            });

            modelBuilder.Entity<Regc112>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY22");

                entity.HasIndex(e => new { e.C110Id, e.C110CodInf })
                    .HasName("FK_REGC112_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Regc114>(entity =>
            {
                entity.HasKey(e => new { e.C110Id, e.C110CodInf, e.EcfFab, e.NumDoc, e.DtDoc })
                    .HasName("PK_REGC114");

                entity.HasIndex(e => new { e.C110Id, e.C110CodInf })
                    .HasName("FK_REGC114_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.C110Id, e.C110CodInf, e.DtDoc, e.EcfFab, e.NumDoc })
                    .HasName("PK_REGC114");
            });

            modelBuilder.Entity<Regc120>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CodDocImp, e.NumDocImp })
                    .HasName("PK_REGC120");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC120")
                    .IsUnique();

                entity.HasIndex(e => e.NumAcdraw)
                    .HasName("UK_REGC120_01");

                entity.HasIndex(e => new { e.CodDocImp, e.Id, e.NumDocImp })
                    .HasName("PK_REGC120");
            });

            modelBuilder.Entity<Regc140>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGC140");
            });

            modelBuilder.Entity<Regc141>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumParc })
                    .HasName("PK_REGC141");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC141_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumParc })
                    .HasName("PK_REGC141");
            });

            modelBuilder.Entity<Regc170>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGC170");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGC170_05")
                    .IsUnique();

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGC170_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodNat)
                    .HasName("FK_REGC170_04")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC170_01")
                    .IsUnique();

                entity.HasIndex(e => e.Unid)
                    .HasName("FK_REGC170_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGC170");
            });

            modelBuilder.Entity<Regc176>(entity =>
            {
                entity.HasKey(e => new { e.C176Id, e.C170Id, e.C170NumItem })
                    .HasName("PK_REGC176");

                entity.HasIndex(e => new { e.C170Id, e.C170NumItem })
                    .HasName("FK_REGC176_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.C170Id, e.C170NumItem, e.C176Id })
                    .HasName("PK_REGC176");
            });

            modelBuilder.Entity<Regc195>(entity =>
            {
                entity.HasKey(e => new { e.CodObs, e.Id })
                    .HasName("RDB$PRIMARY29");

                entity.HasIndex(e => e.CodObs)
                    .HasName("FK_REGC195_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC195_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.CodObs, e.Id })
                    .HasName("RDB$PRIMARY29");
            });

            modelBuilder.Entity<Regc300>(entity =>
            {
                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGC300_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY23");
            });

            modelBuilder.Entity<Regc300Pagamento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.MeioPagamento })
                    .HasName("PK_REGC300_PAGAMENTO");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC300_PAGAMENTO_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.MeioPagamento })
                    .HasName("PK_REGC300_PAGAMENTO");
            });

            modelBuilder.Entity<Regc310>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumDocCanc })
                    .HasName("RDB$PRIMARY24");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC310_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumDocCanc })
                    .HasName("RDB$PRIMARY24");
            });

            modelBuilder.Entity<Regc321>(entity =>
            {
                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGC321_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY25");

                entity.HasIndex(e => e.Regc300Id)
                    .HasName("FK_REGC321_01")
                    .IsUnique();

                entity.HasIndex(e => e.Unid)
                    .HasName("FK_REGC321_03")
                    .IsUnique();
            });

            modelBuilder.Entity<Regc400>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGC400");
            });

            modelBuilder.Entity<Regc405>(entity =>
            {
                entity.HasKey(e => new { e.Regc400Id, e.Id })
                    .HasName("PK_REGC405");

                entity.HasIndex(e => e.Regc400Id)
                    .HasName("FK_REGC405_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Regc400Id })
                    .HasName("PK_REGC405");
            });

            modelBuilder.Entity<Regc410>(entity =>
            {
                entity.HasKey(e => new { e.Regc400Id, e.Regc405Id })
                    .HasName("PK_REGC410");

                entity.HasIndex(e => new { e.Regc400Id, e.Regc405Id })
                    .HasName("PK_REGC410");
            });

            modelBuilder.Entity<Regc420>(entity =>
            {
                entity.HasKey(e => new { e.Regc400Id, e.Regc405Id, e.Id })
                    .HasName("PK_REGC420");

                entity.HasIndex(e => new { e.Regc400Id, e.Regc405Id })
                    .HasName("FK_REGC420_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Regc400Id, e.Regc405Id })
                    .HasName("PK_REGC420");
            });

            modelBuilder.Entity<Regc425>(entity =>
            {
                entity.HasKey(e => new { e.Regc400Id, e.Regc405Id, e.Regc420Id, e.Id })
                    .HasName("PK_REGC425");

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGC425_02")
                    .IsUnique();

                entity.HasIndex(e => e.Unid)
                    .HasName("FK_REGC425_03")
                    .IsUnique();

                entity.HasIndex(e => new { e.Regc400Id, e.Regc420Id, e.Regc405Id })
                    .HasName("FK_REGC425_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Regc400Id, e.Regc420Id, e.Regc405Id })
                    .HasName("PK_REGC425");
            });

            modelBuilder.Entity<Regc490>(entity =>
            {
                entity.HasKey(e => new { e.Regc400Id, e.Regc405Id, e.Id })
                    .HasName("PK_REGC490");

                entity.HasIndex(e => new { e.Regc400Id, e.Regc405Id })
                    .HasName("FK_REGC490_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Regc400Id, e.Regc405Id })
                    .HasName("PK_REGC490");
            });

            modelBuilder.Entity<Regc500>(entity =>
            {
                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_REGC500_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGC500_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY11");
            });

            modelBuilder.Entity<Regc501>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdC501 })
                    .HasName("PK_REGC501");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGC501_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC501")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdC501 })
                    .HasName("PK_REGC501");
            });

            modelBuilder.Entity<Regc505>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdC505 })
                    .HasName("PK_REGC505");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGC505_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGC505")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdC505 })
                    .HasName("PK_REGC505");
            });

            modelBuilder.Entity<Regd100>(entity =>
            {
                entity.HasIndex(e => e.ChvCte)
                    .HasName("IX_REGD100_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD100_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_REGD100_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGD100_01")
                    .IsUnique();

                entity.HasIndex(e => e.DtAP)
                    .HasName("IX_REGD100_04")
                    .IsUnique();

                entity.HasIndex(e => e.DtDoc)
                    .HasName("IX_REGD100_03")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY12");

                entity.HasIndex(e => e.IndOper)
                    .HasName("IX_REGD100_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Regd101>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdD101 })
                    .HasName("PK_REGD101");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD101_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD101_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdD101 })
                    .HasName("PK_REGD101");
            });

            modelBuilder.Entity<Regd101Fiscal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGD101_FISCAL");
            });

            modelBuilder.Entity<Regd105>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdD105 })
                    .HasName("PK_REGD105");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD105_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD105_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdD105 })
                    .HasName("PK_REGD105");
            });

            modelBuilder.Entity<Regd110>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGD110");

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGD110_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD110_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("PK_REGD110");
            });

            modelBuilder.Entity<Regd120>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NumItem, e.Numero })
                    .HasName("PK_REGD120");

                entity.HasIndex(e => new { e.Id, e.NumItem })
                    .HasName("FK_REGD120_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.NumItem, e.Numero })
                    .HasName("PK_REGD120");
            });

            modelBuilder.Entity<Regd201>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_REGD201");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD201_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD201_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_REGD201");
            });

            modelBuilder.Entity<Regd205>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_REGD205");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD205_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD205_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_REGD205");
            });

            modelBuilder.Entity<Regd500>(entity =>
            {
                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD500_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodInf)
                    .HasName("FK_REGD500_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGD500_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY13");
            });

            modelBuilder.Entity<Regd501>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdD501 })
                    .HasName("PK_REGD501");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD501_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD501_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdD501 })
                    .HasName("PK_REGD501");
            });

            modelBuilder.Entity<Regd505>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdD505 })
                    .HasName("PK_REGD505");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGD505_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGD505_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.IdD505 })
                    .HasName("PK_REGD505");
            });

            modelBuilder.Entity<Regf100>(entity =>
            {
                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGF100_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGF100_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGF100");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_REGF100_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Regf600>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGF600");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_REGF600_01")
                    .IsUnique();
            });

            modelBuilder.Entity<Regh005>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGH005");
            });

            modelBuilder.Entity<Regh010>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_REGH010");

                entity.HasIndex(e => e.CodCta)
                    .HasName("FK_REGH010_04")
                    .IsUnique();

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGH010_02")
                    .IsUnique();

                entity.HasIndex(e => e.CodPart)
                    .HasName("FK_REGH010_03")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGH010_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_REGH010");
            });

            modelBuilder.Entity<Regh020>(entity =>
            {
                entity.HasKey(e => new { e.CstIcms, e.Numero, e.Id })
                    .HasName("PK_REGH020");

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("FK_REGH020_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.CstIcms, e.Id, e.Numero })
                    .HasName("PK_REGH020");
            });

            modelBuilder.Entity<Regk250>(entity =>
            {
                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGK250_01")
                    .IsUnique();

                entity.HasIndex(e => e.DtProd)
                    .HasName("IX_REGK250_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGK250");
            });

            modelBuilder.Entity<Regk255>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Id })
                    .HasName("PK_REGK255");

                entity.HasIndex(e => e.CodInsSubst)
                    .HasName("FK_REGK255_03")
                    .IsUnique();

                entity.HasIndex(e => e.CodItem)
                    .HasName("FK_REGK255_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGK255_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Numero })
                    .HasName("PK_REGK255");
            });

            modelBuilder.Entity<RegraTributaria>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGRA_TRIBUTARIA");
            });

            modelBuilder.Entity<RegraTributariaCte>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_REGRA_TRIBUTARIA_CTE");
            });

            modelBuilder.Entity<RegraTributariaCteIcmsAliq>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Tipo, e.Uf })
                    .HasName("PK_RTIA_CTE");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_REGRA_TRIB_CTE_ICMS_ALIQ_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Tipo, e.Uf })
                    .HasName("PK_RTIA_CTE");
            });

            modelBuilder.Entity<RegraTributariaIcmsAliquota>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Tipo, e.Uf })
                    .HasName("PK_RTIA");

                entity.HasIndex(e => e.Id)
                    .HasName("FK_RTIA_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.Tipo, e.Uf })
                    .HasName("PK_RTIA");
            });

            modelBuilder.Entity<SeguroCarga>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_SEGURO_CARGA");
            });

            modelBuilder.Entity<TabelaPrecoCompra>(entity =>
            {
                entity.HasKey(e => new { e.PessoaId, e.Cprod })
                    .HasName("PK_TABELA_PRECO_COMPRA");

                entity.HasIndex(e => e.Cprod)
                    .HasName("FK_TABELA_PRECO_COMPRA_02")
                    .IsUnique();

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_TABELA_PRECO_COMPRA_01")
                    .IsUnique();

                entity.HasIndex(e => new { e.Cprod, e.PessoaId })
                    .HasName("PK_TABELA_PRECO_COMPRA");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => new { e.Tabela, e.Id })
                    .HasName("PK_TAG");

                entity.HasIndex(e => new { e.Id, e.Tabela })
                    .HasName("PK_TAG");

                entity.Property(e => e.Custom).HasDefaultValueSql("DEFAULT 1");
            });

            modelBuilder.Entity<TipoConta>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TIPO_CONTA");
            });

            modelBuilder.Entity<TipoDocumentoFinanceiro>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TIP_DOC_FIN");
            });

            modelBuilder.Entity<Transportadora>(entity =>
            {
                entity.HasKey(e => e.Cnpjcpf)
                    .HasName("PK_TRANSPORTADORA");

                entity.HasIndex(e => e.Cnpjcpf)
                    .HasName("PK_TRANSPORTADORA");

                entity.HasIndex(e => e.Xnome)
                    .HasName("IX_TRANSPORTADORA_01")
                    .IsUnique();
            });

            modelBuilder.Entity<TsBoletoBoletoLocal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_BOLETO_LOCAL");

                entity.HasIndex(e => e.IdIntegracao)
                    .HasName("IX_TS_BOLETO_BOLETO_LOCAL_01")
                    .IsUnique();

                entity.HasIndex(e => e.LancamentoId)
                    .HasName("FK_TS_BOLETO_BOLETO_LOCAL_01")
                    .IsUnique();

                entity.HasIndex(e => e.Situacao)
                    .HasName("IX_TS_BOLETO_BOLETO_LOCAL_02")
                    .IsUnique();

                entity.HasIndex(e => e.TituloDataVencimento)
                    .HasName("IX_TS_BOLETO_BOLETO_LOCAL_03")
                    .IsUnique();

                entity.Property(e => e.ImpressaoVisualizada).HasDefaultValueSql("DEFAULT 0");

                entity.Property(e => e.PagamentoRealizado).HasDefaultValueSql("DEFAULT 0");
            });

            modelBuilder.Entity<TsBoletoContaApi>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_CONTA_API");
            });

            modelBuilder.Entity<TsBoletoContaLocal>(entity =>
            {
                entity.HasIndex(e => e.ContaCapitalId)
                    .HasName("FK_TS_BOLETO_CONTA_LOCAL_02")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_CONTA_LOCAL");
            });

            modelBuilder.Entity<TsBoletoConvenioApi>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_CONVENIO_API");

                entity.HasIndex(e => e.IdConta)
                    .HasName("FK_TS_BOLETO_CONVENIO_API_01")
                    .IsUnique();
            });

            modelBuilder.Entity<TsBoletoConvenioLocal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_CONVENIO_LOCAL");
            });

            modelBuilder.Entity<TsBoletoRemessaLocal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_REMESSA_LOCAL");
            });

            modelBuilder.Entity<TsBoletoRetornoLocal>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_TS_BOLETO_RETORNO_LOCAL");

                entity.HasIndex(e => e.Protocolo)
                    .HasName("IX_TS_BOLETO_RETORNO_LOCAL_01")
                    .IsUnique();

                entity.HasIndex(e => e.Situacao)
                    .HasName("IX_TS_BOLETO_RETORNO_LOCAL_02")
                    .IsUnique();
            });

            modelBuilder.Entity<UnidadeMedida>(entity =>
            {
                entity.HasKey(e => e.Unid)
                    .HasName("PK_UNIDADE_MEDIDA");

                entity.HasIndex(e => e.Unid)
                    .HasName("PK_UNIDADE_MEDIDA");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.Ativo)
                    .HasName("IX_USUARIO_02")
                    .IsUnique();

                entity.HasIndex(e => e.GrupoUsuarioId)
                    .HasName("IX_USUARIO_01")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("PK_USUARIO");

                entity.HasIndex(e => e.PessoaId)
                    .HasName("FK_USUARIO_02")
                    .IsUnique();
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_VEICULO");
            });

            modelBuilder.Entity<Versao>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("RDB$PRIMARY7");
            });

            modelBuilder.Entity<VindiBills>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_VINDI_BILLS");
            });

            modelBuilder.Entity<VindiCustomers>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_VINDI_CUSTOMERS");

                entity.HasIndex(e => e.Code)
                    .HasName("PK_VINDI_CUSTOMERS");
            });

            modelBuilder.Entity<VindiPlanoContas>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("PK_VINDI_PLANO_CONTAS");
            });
        }
    }
}
