using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Servico", Schema = "Cadastro")]
    public partial class Servico
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }
        public short? NaturezadaOperacao { get; set; }
        [StringLength(2000)]
        public string Discriminacao { get; set; }
        [StringLength(20)]
        public string CodigoTributacaoMunicipio { get; set; }
        [StringLength(5)]
        public string ItemListaServico { get; set; }
        [Column(TypeName = "numeric(5,4)")]
        public decimal? AliquotaServicos { get; set; }
        [StringLength(7)]
        public string CodigoCnae { get; set; }
        public int? MunicipioPrestacaoServico { get; set; }
    }
}
