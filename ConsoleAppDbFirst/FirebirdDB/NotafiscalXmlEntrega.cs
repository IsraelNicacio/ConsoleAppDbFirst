using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_ENTREGA         ")]
    public partial class NotafiscalXmlEntrega
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CNPJCPF")]
        [StringLength(14)]
        public string Cnpjcpf { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("XLGR")]
        [StringLength(60)]
        public string Xlgr { get; set; }
        [Column("NRO")]
        [StringLength(60)]
        public string Nro { get; set; }
        [Column("XCPL")]
        [StringLength(60)]
        public string Xcpl { get; set; }
        [Column("XBAIRRO")]
        [StringLength(60)]
        public string Xbairro { get; set; }
        [Column("CMUN")]
        [StringLength(7)]
        public string Cmun { get; set; }
        [Column("XMUN")]
        [StringLength(60)]
        public string Xmun { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("CEP")]
        [StringLength(8)]
        public string Cep { get; set; }
        [Column("CPAIS")]
        [StringLength(4)]
        public string Cpais { get; set; }
        [Column("XPAIS")]
        [StringLength(60)]
        public string Xpais { get; set; }
        [Column("FONE")]
        [StringLength(14)]
        public string Fone { get; set; }
        [Column("EMAIL")]
        [StringLength(60)]
        public string Email { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
    }
}
