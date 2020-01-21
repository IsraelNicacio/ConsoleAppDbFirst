using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PRODUTO                        ")]
    public partial class Produto
    {
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("XPROD")]
        [StringLength(120)]
        public string Xprod { get; set; }
        [Column("CEAN")]
        [StringLength(14)]
        public string Cean { get; set; }
        [Column("CEANTRIB")]
        [StringLength(14)]
        public string Ceantrib { get; set; }
        [Column("EXTIPI")]
        [StringLength(3)]
        public string Extipi { get; set; }
        [Column("NCM")]
        [StringLength(8)]
        public string Ncm { get; set; }
        [Column("CEST")]
        [StringLength(7)]
        public string Cest { get; set; }
        [Column("CFOP")]
        public int? Cfop { get; set; }
        [Column("UCOM")]
        [StringLength(6)]
        public string Ucom { get; set; }
        [Column("QCOM", TypeName = "DECIMAL(15, 4)")]
        public decimal? Qcom { get; set; }
        [Column("VUNCOM", TypeName = "DECIMAL(18, 4)")]
        public decimal? Vuncom { get; set; }
        [Column("UTRIB")]
        [StringLength(6)]
        public string Utrib { get; set; }
        [Column("QTRIB", TypeName = "DECIMAL(15, 4)")]
        public decimal? Qtrib { get; set; }
        [Column("VUNTRIB", TypeName = "DECIMAL(18, 4)")]
        public decimal? Vuntrib { get; set; }
        [Column("TIPO_ITEM")]
        [StringLength(2)]
        public string TipoItem { get; set; }
        [Column("COD_GEN")]
        public int? CodGen { get; set; }
        [Column("COD_LST")]
        public int? CodLst { get; set; }
        [Column("PESO_BRUTO", TypeName = "DECIMAL(15, 4)")]
        public decimal? PesoBruto { get; set; }
        [Column("PESO_LIQUIDO", TypeName = "DECIMAL(15, 4)")]
        public decimal? PesoLiquido { get; set; }
        [Column("VOLUME", TypeName = "DECIMAL(15, 4)")]
        public decimal? Volume { get; set; }
        [Column("ESTOQUE_MINIMO", TypeName = "DECIMAL(15, 4)")]
        public decimal? EstoqueMinimo { get; set; }
        [Column("ESTOQUE_MAXIMO", TypeName = "DECIMAL(15, 4)")]
        public decimal? EstoqueMaximo { get; set; }
        [Column("PONTO_REPOSICAO", TypeName = "DECIMAL(15, 4)")]
        public decimal? PontoReposicao { get; set; }
        [Column("ALIQ_IPI", TypeName = "DECIMAL(15, 2)")]
        public decimal? AliqIpi { get; set; }
        [Column("ALIQ_ICMS", TypeName = "DECIMAL(15, 2)")]
        public decimal? AliqIcms { get; set; }
        [Column("REDUCAO_BC_ICMS", TypeName = "DECIMAL(15, 2)")]
        public decimal? ReducaoBcIcms { get; set; }
        [Column("BC_ICMS_ST", TypeName = "DECIMAL(15, 2)")]
        public decimal? BcIcmsSt { get; set; }
        [Column("ALIQ_ISS", TypeName = "DECIMAL(15, 2)")]
        public decimal? AliqIss { get; set; }
        [Column("IAT")]
        [StringLength(1)]
        public string Iat { get; set; }
        [Column("IPPT")]
        [StringLength(1)]
        public string Ippt { get; set; }
        [Column("SITUACAO_TRIBUTARIA")]
        [StringLength(1)]
        public string SituacaoTributaria { get; set; }
        [Column("INDICADOR_FRACIONAMENTO")]
        public int IndicadorFracionamento { get; set; }
        [Column("CODIGO_AUXILIAR")]
        [StringLength(60)]
        public string CodigoAuxiliar { get; set; }
        [Column("CODIGO_AUXILIAR2")]
        [StringLength(60)]
        public string CodigoAuxiliar2 { get; set; }
        [Column("IDENTIFICACAO_AUXILIAR")]
        [StringLength(256)]
        public string IdentificacaoAuxiliar { get; set; }
        [Column("CHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Chave { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }
        [Column("PRODUTO_GRUPO_ID")]
        public int? ProdutoGrupoId { get; set; }
        [Column("MINIATURA")]
        public byte[] Miniatura { get; set; }
        [Column("GRADE_ID")]
        public int? GradeId { get; set; }
        [Column("INDICADOR_LOTE")]
        public short? IndicadorLote { get; set; }
        [Column("UNIDADE_INVENTARIO")]
        [StringLength(6)]
        public string UnidadeInventario { get; set; }
        [Column("CRIACAO_USUARIO_ID")]
        public int? CriacaoUsuarioId { get; set; }
        [Column("CRIACAO_DATA_HORA")]
        public DateTime? CriacaoDataHora { get; set; }
        [Column("ULTIMA_ATUALIZACAO_USUARIO_ID")]
        public int? UltimaAtualizacaoUsuarioId { get; set; }
        [Column("ULTIMA_ATUALIZACAO_DATA_HORA")]
        public DateTime? UltimaAtualizacaoDataHora { get; set; }
        [Column("NFCI")]
        [StringLength(36)]
        public string Nfci { get; set; }
        [Column("LARGURA", TypeName = "DECIMAL(18, 4)")]
        public decimal? Largura { get; set; }
        [Column("ALTURA", TypeName = "DECIMAL(18, 4)")]
        public decimal? Altura { get; set; }
        [Column("COMPRIMENTO", TypeName = "DECIMAL(18, 4)")]
        public decimal? Comprimento { get; set; }
        [Column("INFADPROD")]
        [StringLength(500)]
        public string Infadprod { get; set; }
        [Column("ORIG")]
        public short? Orig { get; set; }
    }
}
