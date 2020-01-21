using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ESTOQUE                        ")]
    public partial class Estoque
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ID_REF")]
        public long? IdRef { get; set; }
        [Column("DATA_MOVIMENTO")]
        public DateTime DataMovimento { get; set; }
        [Column("OPERACAO")]
        public int Operacao { get; set; }
        [Required]
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Required]
        [Column("IND_PROPRIEDADE")]
        [StringLength(2)]
        public string IndPropriedade { get; set; }
        [Column("PESSOA_ID")]
        public long? PessoaId { get; set; }
        [Column("LOCAL")]
        public int? Local { get; set; }
        [Column("CFOP")]
        public int? Cfop { get; set; }
        [Required]
        [Column("UNID")]
        [StringLength(6)]
        public string Unid { get; set; }
        [Column("QTDE", TypeName = "DECIMAL(18, 4)")]
        public decimal Qtde { get; set; }
        [Column("VALOR_UNITARIO", TypeName = "DECIMAL(18, 4)")]
        public decimal ValorUnitario { get; set; }
        [Column("VALOR_TOTAL", TypeName = "DECIMAL(18, 4)")]
        public decimal ValorTotal { get; set; }
        [Column("VALOR_TOTAL_ICMS", TypeName = "DECIMAL(18, 4)")]
        public decimal? ValorTotalIcms { get; set; }
        [Column("VALOR_TOTAL_IPI", TypeName = "DECIMAL(18, 4)")]
        public decimal? ValorTotalIpi { get; set; }
        [Column("PESO_BRUTO_TOTAL", TypeName = "DECIMAL(18, 4)")]
        public decimal? PesoBrutoTotal { get; set; }
        [Column("PESO_LIQUIDO_TOTAL", TypeName = "DECIMAL(18, 4)")]
        public decimal? PesoLiquidoTotal { get; set; }
        [Column("TIPO_DOCUMENTO")]
        [StringLength(2)]
        public string TipoDocumento { get; set; }
        [Column("NUM_DOCUMENTO")]
        [StringLength(256)]
        public string NumDocumento { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(2048)]
        public string Observacao { get; set; }
        [Column("NUM_LOTE")]
        [StringLength(512)]
        public string NumLote { get; set; }
        [Column("DATA_FABRICACAO")]
        public DateTime? DataFabricacao { get; set; }
        [Column("NUM_DIAS_AVISO_VENC")]
        public int? NumDiasAvisoVenc { get; set; }
        [Column("DATA_VALIDADE")]
        public DateTime? DataValidade { get; set; }
        [Column("NUMNF")]
        public int? Numnf { get; set; }
        [Column("SERIE")]
        [StringLength(4)]
        public string Serie { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
    }
}
