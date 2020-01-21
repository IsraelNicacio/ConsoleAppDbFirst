using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TRANSPORTADORA                 ")]
    public partial class Transportadora
    {
        [Column("CNPJCPF")]
        [StringLength(14)]
        public string Cnpjcpf { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Column("XENDER")]
        [StringLength(60)]
        public string Xender { get; set; }
        [Column("XMUN")]
        [StringLength(60)]
        public string Xmun { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
    }
}
