using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ENDERECO                       ")]
    public partial class Endereco
    {
        [Column("CENDERECO")]
        public int Cendereco { get; set; }
        [Required]
        [Column("CTIPO", TypeName = "CHAR(1) CHARACTER SET UNICODE_FSS")]
        public string Ctipo { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Required]
        [Column("CNPJCPF")]
        [StringLength(14)]
        public string Cnpjcpf { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Required]
        [Column("XLGR")]
        [StringLength(60)]
        public string Xlgr { get; set; }
        [Required]
        [Column("NRO")]
        [StringLength(60)]
        public string Nro { get; set; }
        [Column("XCPL")]
        [StringLength(60)]
        public string Xcpl { get; set; }
        [Required]
        [Column("XBAIRRO")]
        [StringLength(60)]
        public string Xbairro { get; set; }
        [Column("CMUN")]
        [StringLength(7)]
        public string Cmun { get; set; }
        [Column("XMUN")]
        [StringLength(60)]
        public string Xmun { get; set; }
        [Column("UF", TypeName = "CHAR(2) CHARACTER SET UNICODE_FSS")]
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
    }
}
