using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONTA_CAPITAL                  ")]
    public partial class ContaCapital
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(64)]
        public string Nome { get; set; }
        [Column("TIPO_CONTA_ID")]
        public int TipoContaId { get; set; }
        [Required]
        [Column("MOEDA_ID")]
        [StringLength(6)]
        public string MoedaId { get; set; }
        [Column("BANCO_ID")]
        [StringLength(3)]
        public string BancoId { get; set; }
        [Column("AGENCIA")]
        [StringLength(10)]
        public string Agencia { get; set; }
        [Column("DIGITO_AGENCIA")]
        [StringLength(5)]
        public string DigitoAgencia { get; set; }
        [Column("NUM_CONTA")]
        [StringLength(10)]
        public string NumConta { get; set; }
        [Column("DIGITO_CONTA")]
        [StringLength(5)]
        public string DigitoConta { get; set; }
        [Column("LIMITE_CREDITO", TypeName = "DECIMAL(18, 6)")]
        public decimal? LimiteCredito { get; set; }
        [Column("CONTA_ENCERRADA", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string ContaEncerrada { get; set; }
        [Column("NOME_CONTATO")]
        [StringLength(64)]
        public string NomeContato { get; set; }
        [Column("CARGO_CONTATO")]
        [StringLength(64)]
        public string CargoContato { get; set; }
        [Column("TELEFONE")]
        [StringLength(14)]
        public string Telefone { get; set; }
        [Column("EMAIL")]
        [StringLength(64)]
        public string Email { get; set; }
        [Column("HOME_PAGE")]
        [StringLength(64)]
        public string HomePage { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
        [Column("DIA_VENCIMENTO")]
        public int? DiaVencimento { get; set; }
    }
}
