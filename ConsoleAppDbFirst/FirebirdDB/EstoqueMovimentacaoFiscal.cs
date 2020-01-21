using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE_MOVIMENTACAO_FISCAL    ")]
    public partial class EstoqueMovimentacaoFiscal
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("VALOR_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal? ValorItem { get; set; }
        [Column("FRETE", TypeName = "DECIMAL(18, 2)")]
        public decimal? Frete { get; set; }
        [Column("SEGURO", TypeName = "DECIMAL(18, 2)")]
        public decimal? Seguro { get; set; }
        [Column("DESCONTO", TypeName = "DECIMAL(18, 2)")]
        public decimal? Desconto { get; set; }
        [Column("OUTRAS_DESPESAS", TypeName = "DECIMAL(18, 2)")]
        public decimal? OutrasDespesas { get; set; }
        [Column("DESPESA_ADUANEIRA", TypeName = "DECIMAL(18, 2)")]
        public decimal? DespesaAduaneira { get; set; }
        [Column("IOF", TypeName = "DECIMAL(18, 2)")]
        public decimal? Iof { get; set; }
        [Column("ICMS_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? IcmsBase { get; set; }
        [Column("ICMS_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? IcmsValor { get; set; }
        [Column("ICMS_ST_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? IcmsStBase { get; set; }
        [Column("ICMS_ST_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? IcmsStValor { get; set; }
        [Column("IPI_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? IpiBase { get; set; }
        [Column("IPI_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? IpiValor { get; set; }
        [Column("PIS_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? PisBase { get; set; }
        [Column("PIS_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? PisValor { get; set; }
        [Column("COFINS_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? CofinsBase { get; set; }
        [Column("COFINS_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? CofinsValor { get; set; }
        [Column("II_BASE", TypeName = "DECIMAL(18, 2)")]
        public decimal? IiBase { get; set; }
        [Column("II_VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? IiValor { get; set; }
    }
}
