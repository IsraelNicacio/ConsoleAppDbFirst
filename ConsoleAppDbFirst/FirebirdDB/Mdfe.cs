using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MDFE                           ")]
    public partial class Mdfe
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CSTAT")]
        [StringLength(4)]
        public string Cstat { get; set; }
        [Column("XMOTIVO")]
        [StringLength(256)]
        public string Xmotivo { get; set; }
        [Column("IMPRESSO")]
        public int? Impresso { get; set; }
        [Required]
        [Column("VERSAO")]
        [StringLength(4)]
        public string Versao { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NMDF")]
        public int Nmdf { get; set; }
        [Column("CHMDFE")]
        [StringLength(44)]
        public string Chmdfe { get; set; }
        [Column("DHEMI")]
        public DateTime Dhemi { get; set; }
        [Column("DHINIVIAGEM")]
        public DateTime? Dhiniviagem { get; set; }
        [Column("MODAL")]
        public int Modal { get; set; }
        [Column("TPEMIT")]
        public int? Tpemit { get; set; }
        [Column("TPTRANSP")]
        public int? Tptransp { get; set; }
        [Column("TPEMIS")]
        public int? Tpemis { get; set; }
        [Column("UFINI", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string Ufini { get; set; }
        [Column("UFFIM", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string Uffim { get; set; }
        [Column("UFPER")]
        [StringLength(128)]
        public string Ufper { get; set; }
        [Column("QCTE")]
        public int? Qcte { get; set; }
        [Column("QCT")]
        public int? Qct { get; set; }
        [Column("QNFE")]
        public int? Qnfe { get; set; }
        [Column("QNF")]
        public int? Qnf { get; set; }
        [Column("QMDFE")]
        public int? Qmdfe { get; set; }
        [Column("VCARGA", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vcarga { get; set; }
        [Column("CUNID")]
        [StringLength(2)]
        public string Cunid { get; set; }
        [Column("QCARGA", TypeName = "DECIMAL(11, 4)")]
        public decimal? Qcarga { get; set; }
        [Required]
        [Column("XML", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xml { get; set; }
        [Column("MDFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Mdfe1 { get; set; }
        [Column("DHREC")]
        public DateTime? Dhrec { get; set; }
        [Column("NREC")]
        [StringLength(15)]
        public string Nrec { get; set; }
        [Column("PROTMDFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Protmdfe { get; set; }
        [Column("DHPROT")]
        public DateTime? Dhprot { get; set; }
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("INDCARREGAPOSTERIOR")]
        public int? Indcarregaposterior { get; set; }
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
