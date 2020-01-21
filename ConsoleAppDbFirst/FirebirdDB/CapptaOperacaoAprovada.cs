using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CAPPTA_OPERACAO_APROVADA       ")]
    public partial class CapptaOperacaoAprovada
    {
        [Column("NSU_TEF")]
        public long NsuTef { get; set; }
        [Column("NSU_ADQUIRENTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string NsuAdquirente { get; set; }
        [Column("CODIGO_AUTORIZACAO_ADQUIRENTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string CodigoAutorizacaoAdquirente { get; set; }
        [Column("CUPOM_CLIENTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string CupomCliente { get; set; }
        [Column("CUPOM_LOJISTA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string CupomLojista { get; set; }
        [Column("CUPOM_REDUZIDO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string CupomReduzido { get; set; }
        [Column("NOME_ADQUIRENTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string NomeAdquirente { get; set; }
        [Column("NOME_BANDEIRA_CARTAO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string NomeBandeiraCartao { get; set; }
        [Column("NUMERO_CONTROLE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string NumeroControle { get; set; }
        [Column("DATA_HORA_AUTORIZACAO")]
        public DateTime? DataHoraAutorizacao { get; set; }
        [Column("OPERACAO")]
        [StringLength(32)]
        public string Operacao { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 2)")]
        public decimal? Valor { get; set; }
        [Column("QUANTIDADE_PARCELAS")]
        public int? QuantidadeParcelas { get; set; }
        [Column("TIPO_PARCELAMENTO")]
        public int? TipoParcelamento { get; set; }
    }
}
