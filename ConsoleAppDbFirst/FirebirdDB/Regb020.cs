using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGB020                        ")]
    public partial class Regb020
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("IND_OPER")]
        [StringLength(1)]
        public string IndOper { get; set; }
        [Required]
        [Column("IND_EMIT")]
        [StringLength(1)]
        public string IndEmit { get; set; }
        [Column("COD_PART")]
        public long? CodPart { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Column("COD_SIT")]
        public int CodSit { get; set; }
        [Column("SER")]
        [StringLength(3)]
        public string Ser { get; set; }
        [Column("NUM_DOC")]
        public int NumDoc { get; set; }
        [Column("CHV_NFE")]
        [StringLength(44)]
        public string ChvNfe { get; set; }
        [Column("DT_DOC")]
        public DateTime DtDoc { get; set; }
        [Column("COD_MUN_SERV")]
        [StringLength(7)]
        public string CodMunServ { get; set; }
        [Column("VL_CONT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlCont { get; set; }
        [Column("VL_MAT_TERC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlMatTerc { get; set; }
        [Column("VL_SUB", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlSub { get; set; }
        [Column("VL_ISNT_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIsntIss { get; set; }
        [Column("VL_DED_BC", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlDedBc { get; set; }
        [Column("VL_BC_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIss { get; set; }
        [Column("VL_BC_ISS_RT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlBcIssRt { get; set; }
        [Column("VL_ISS_RT", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIssRt { get; set; }
        [Column("VL_ISS", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlIss { get; set; }
        [Column("COD_INF_OBS")]
        [StringLength(60)]
        public string CodInfObs { get; set; }
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
