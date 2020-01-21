using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_TRANSP          ")]
    public partial class NotafiscalXmlTransp
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("MODFRETE")]
        public int Modfrete { get; set; }
        [Column("TRANSP_CNPJCPF")]
        [StringLength(14)]
        public string TranspCnpjcpf { get; set; }
        [Column("TRANSP_XNOME")]
        [StringLength(60)]
        public string TranspXnome { get; set; }
        [Column("TRANSP_IE")]
        [StringLength(14)]
        public string TranspIe { get; set; }
        [Column("TRANSP_XENDER")]
        [StringLength(60)]
        public string TranspXender { get; set; }
        [Column("TRANSP_XMUN")]
        [StringLength(60)]
        public string TranspXmun { get; set; }
        [Column("TRANSP_UF")]
        [StringLength(2)]
        public string TranspUf { get; set; }
        [Column("VEIC_PLACA")]
        [StringLength(7)]
        public string VeicPlaca { get; set; }
        [Column("VEIC_UF")]
        [StringLength(2)]
        public string VeicUf { get; set; }
        [Column("VEIC_RNTC")]
        [StringLength(20)]
        public string VeicRntc { get; set; }
        [Column("VAGAO")]
        [StringLength(20)]
        public string Vagao { get; set; }
        [Column("BALSA")]
        [StringLength(20)]
        public string Balsa { get; set; }
    }
}
