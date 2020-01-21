using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_CONTA_API            ")]
    public partial class TsBoletoContaApi
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("CODIGO_BANCO")]
        [StringLength(8)]
        public string CodigoBanco { get; set; }
        [Column("CODIGO_BANCO_CORRESPONDENTE")]
        [StringLength(8)]
        public string CodigoBancoCorrespondente { get; set; }
        [Column("AGENCIA")]
        [StringLength(16)]
        public string Agencia { get; set; }
        [Column("AGENCIA_DV")]
        [StringLength(2)]
        public string AgenciaDv { get; set; }
        [Column("CONTA")]
        [StringLength(16)]
        public string Conta { get; set; }
        [Column("CONTA_DV")]
        [StringLength(2)]
        public string ContaDv { get; set; }
        [Column("TIPO_CONTA")]
        [StringLength(32)]
        public string TipoConta { get; set; }
        [Column("COD_BENEFICIARIO")]
        [StringLength(32)]
        public string CodBeneficiario { get; set; }
        [Column("ID_CEDENTE")]
        public int? IdCedente { get; set; }
        [Column("CRIADO")]
        public DateTime? Criado { get; set; }
        [Column("ATUALIZADO")]
        public DateTime? Atualizado { get; set; }
        [Column("COD_EMPRESA")]
        [StringLength(32)]
        public string CodEmpresa { get; set; }
        [Column("JSON", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Json { get; set; }
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
