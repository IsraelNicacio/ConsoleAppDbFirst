using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG1400                        ")]
    public partial class Reg1400
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PERIODO_INICIAL")]
        public DateTime PeriodoInicial { get; set; }
        [Column("PERIODO_FINAL")]
        public DateTime PeriodoFinal { get; set; }
        [Column("COD_PRODUTO")]
        [StringLength(60)]
        public string CodProduto { get; set; }
        [Column("COD_ITEM_IPM")]
        [StringLength(60)]
        public string CodItemIpm { get; set; }
        [Required]
        [Column("MUN")]
        [StringLength(7)]
        public string Mun { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal Valor { get; set; }
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
