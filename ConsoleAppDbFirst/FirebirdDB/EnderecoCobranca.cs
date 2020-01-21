using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ENDERECO_COBRANCA              ")]
    public partial class EnderecoCobranca
    {
        [Column("ID")]
        public long Id { get; set; }
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
        [Required]
        [Column("CMUN")]
        [StringLength(7)]
        public string Cmun { get; set; }
        [Required]
        [Column("XMUN")]
        [StringLength(60)]
        public string Xmun { get; set; }
        [Required]
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
    }
}
