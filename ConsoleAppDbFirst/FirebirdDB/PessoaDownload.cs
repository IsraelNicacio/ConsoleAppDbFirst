using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PESSOA_DOWNLOAD                ")]
    public partial class PessoaDownload
    {
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("CNPJCPF")]
        [StringLength(14)]
        public string Cnpjcpf { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
    }
}
