using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("VINDI_BILLS                    ")]
    public partial class VindiBills
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CODE")]
        public long? Code { get; set; }
        [Column("AMOUNT", TypeName = "DECIMAL(18, 2)")]
        public decimal Amount { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(32)]
        public string Status { get; set; }
        [Column("BILLING_AT")]
        public DateTime? BillingAt { get; set; }
        [Column("DUE_AT")]
        public DateTime? DueAt { get; set; }
        [Column("PAID_AT")]
        public DateTime? PaidAt { get; set; }
        [Column("PAID_AMOUNT", TypeName = "DECIMAL(18, 2)")]
        public decimal? PaidAmount { get; set; }
        [Required]
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
