using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL                     ")]
    public partial class Notafiscal
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Required]
        [Column("VERSAO")]
        [StringLength(4)]
        public string Versao { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("CSTAT")]
        [StringLength(4)]
        public string Cstat { get; set; }
        [Column("XMOTIVO")]
        [StringLength(256)]
        public string Xmotivo { get; set; }
        [Column("CHNFE")]
        [StringLength(44)]
        public string Chnfe { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NNF")]
        public int Nnf { get; set; }
        [Column("DHEMI")]
        public DateTime Dhemi { get; set; }
        [Column("DHSAIENT")]
        public DateTime? Dhsaient { get; set; }
        [Column("NATOP")]
        [StringLength(60)]
        public string Natop { get; set; }
        [Column("INDPAG")]
        public int? Indpag { get; set; }
        [Column("TPNF")]
        public int Tpnf { get; set; }
        [Column("IDDEST")]
        public int? Iddest { get; set; }
        [Column("CMUNFG")]
        [StringLength(7)]
        public string Cmunfg { get; set; }
        [Column("TPIMP")]
        public int Tpimp { get; set; }
        [Column("TPEMIS")]
        public int Tpemis { get; set; }
        [Column("FINNFE")]
        public int Finnfe { get; set; }
        [Column("INDFINAL")]
        public int? Indfinal { get; set; }
        [Column("INDPRES")]
        public int? Indpres { get; set; }
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
        [Required]
        [Column("XML", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xml { get; set; }
        [Column("NFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Nfe { get; set; }
        [Column("DHREC")]
        public DateTime? Dhrec { get; set; }
        [Column("NREC")]
        [StringLength(15)]
        public string Nrec { get; set; }
        [Column("PROTNFE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Protnfe { get; set; }
        [Column("DHPROT")]
        public DateTime? Dhprot { get; set; }
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("XMLDPEC", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmldpec { get; set; }
        [Column("DHREGDPEC")]
        public DateTime? Dhregdpec { get; set; }
        [Column("NREGDPEC")]
        [StringLength(15)]
        public string Nregdpec { get; set; }
        [Column("DANFEIMPRESSO")]
        public int Danfeimpresso { get; set; }
        [Column("PEDIDO_ID")]
        public long? PedidoId { get; set; }
        [Column("PAG_VTROCO", TypeName = "DECIMAL(13, 2)")]
        public decimal? PagVtroco { get; set; }
        [Column("INFNFESUPL_QRCODE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string InfnfesuplQrcode { get; set; }
        [Column("INFNFESUPL_URLCHAVE", TypeName = "BLOB SUB_TYPE TEXT")]
        public string InfnfesuplUrlchave { get; set; }
        [Column("INDSINC")]
        public short? Indsinc { get; set; }
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
