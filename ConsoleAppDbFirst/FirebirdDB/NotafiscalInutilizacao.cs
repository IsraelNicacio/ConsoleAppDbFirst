using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_INUTILIZACAO        ")]
    public partial class NotafiscalInutilizacao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("VERSAO")]
        [StringLength(4)]
        public string Versao { get; set; }
        [Column("TPAMB")]
        [StringLength(1)]
        public string Tpamb { get; set; }
        [Column("CSTAT")]
        [StringLength(3)]
        public string Cstat { get; set; }
        [Column("XMOTIVO")]
        [StringLength(255)]
        public string Xmotivo { get; set; }
        [Column("CUF")]
        [StringLength(2)]
        public string Cuf { get; set; }
        [Column("ANO")]
        [StringLength(2)]
        public string Ano { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("SERIE")]
        [StringLength(3)]
        public string Serie { get; set; }
        [Column("NNFINI")]
        public int? Nnfini { get; set; }
        [Column("NNFFIN")]
        public int? Nnffin { get; set; }
        [Column("XJUST")]
        [StringLength(255)]
        public string Xjust { get; set; }
        [Column("DHRECBTO")]
        public DateTime? Dhrecbto { get; set; }
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("XMLENTRADA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlentrada { get; set; }
        [Column("XMLRETORNO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlretorno { get; set; }
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
