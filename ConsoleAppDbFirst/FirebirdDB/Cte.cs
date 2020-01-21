using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE                            ")]
    public partial class Cte
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("CSTAT")]
        [StringLength(4)]
        public string Cstat { get; set; }
        [Column("XMOTIVO")]
        [StringLength(256)]
        public string Xmotivo { get; set; }
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("DACTE_IMPRESSO")]
        public int? DacteImpresso { get; set; }
        [Required]
        [Column("VERSAO")]
        [StringLength(4)]
        public string Versao { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NCT")]
        public int Nct { get; set; }
        [Column("CFOP", TypeName = "CHAR(4) CHARACTER SET UNICODE_FSS")]
        public string Cfop { get; set; }
        [Column("NATOP")]
        [StringLength(60)]
        public string Natop { get; set; }
        [Column("DHEMI")]
        public DateTime Dhemi { get; set; }
        [Column("MODAL")]
        public int Modal { get; set; }
        [Column("TPCTE")]
        public int? Tpcte { get; set; }
        [Column("TPIMP")]
        public int? Tpimp { get; set; }
        [Column("TPEMIS")]
        public int? Tpemis { get; set; }
        [Column("TPSERV")]
        public int? Tpserv { get; set; }
        [Column("PROCEMI")]
        public int? Procemi { get; set; }
        [Column("VERPROC")]
        [StringLength(40)]
        public string Verproc { get; set; }
        [Column("DHCONT")]
        public DateTime? Dhcont { get; set; }
        [Column("XJUST")]
        [StringLength(256)]
        public string Xjust { get; set; }
        [Column("UFINI", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string Ufini { get; set; }
        [Column("CMUNINI", TypeName = "CHAR(7) CHARACTER SET UNICODE_FSS")]
        public string Cmunini { get; set; }
        [Column("XMUNINI")]
        [StringLength(60)]
        public string Xmunini { get; set; }
        [Column("UFFIM", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
        public string Uffim { get; set; }
        [Column("CMUNFIM", TypeName = "CHAR(7) CHARACTER SET UNICODE_FSS")]
        public string Cmunfim { get; set; }
        [Column("XMUNFIM")]
        [StringLength(60)]
        public string Xmunfim { get; set; }
        [Column("VTPREST", TypeName = "DECIMAL(18, 2)")]
        public decimal? Vtprest { get; set; }
        [Column("VREC", TypeName = "DECIMAL(18, 2)")]
        public decimal? Vrec { get; set; }
        [Required]
        [Column("XML", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xml { get; set; }
        [Column("CTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Cte1 { get; set; }
        [Column("DHREC")]
        public DateTime? Dhrec { get; set; }
        [Column("NREC")]
        [StringLength(15)]
        public string Nrec { get; set; }
        [Column("PROTCTE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Protcte { get; set; }
        [Column("DHPROT")]
        public DateTime? Dhprot { get; set; }
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("INDGLOBALIZADO")]
        public int? Indglobalizado { get; set; }
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
