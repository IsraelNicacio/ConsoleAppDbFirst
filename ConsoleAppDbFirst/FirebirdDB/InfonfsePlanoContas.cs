using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("INFONFSE_PLANO_CONTAS          ")]
    public partial class InfonfsePlanoContas
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ITEM_LISTA_SERVICO")]
        [StringLength(5)]
        public string ItemListaServico { get; set; }
        [Column("CODIGO_TRIBUTACAO_MUNICIPIO")]
        [StringLength(20)]
        public string CodigoTributacaoMunicipio { get; set; }
        [Column("CODIGO_CNAE")]
        [StringLength(7)]
        public string CodigoCnae { get; set; }
        [Column("DISCRIMINACAO")]
        public string Discriminacao { get; set; }
        [Column("ALIQUOTA", TypeName = "DECIMAL(5, 4)")]
        public decimal? Aliquota { get; set; }
        [Column("NATUREZA_OPERACAO")]
        [StringLength(2)]
        public string NaturezaOperacao { get; set; }
        [Column("EXIGIBILIDADE_ISS")]
        [StringLength(2)]
        public string ExigibilidadeIss { get; set; }
        [Column("NUMERO_PROCESSO")]
        [StringLength(30)]
        public string NumeroProcesso { get; set; }
        [Column("PAIS_PRESTACAO")]
        [StringLength(4)]
        public string PaisPrestacao { get; set; }
        [Column("MUNICIPIO_PRESTACAO")]
        [StringLength(7)]
        public string MunicipioPrestacao { get; set; }
        [Column("MUNICIPIO_INCIDENCIA")]
        [StringLength(7)]
        public string MunicipioIncidencia { get; set; }
    }
}
