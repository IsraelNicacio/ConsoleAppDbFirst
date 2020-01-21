using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("PESSOA                         ")]
    public partial class Pessoa
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CNPJCPF")]
        [StringLength(14)]
        public string Cnpjcpf { get; set; }
        [Column("IDESTRANGEIRO")]
        [StringLength(20)]
        public string Idestrangeiro { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Column("IM")]
        [StringLength(15)]
        public string Im { get; set; }
        [Column("ISUF")]
        [StringLength(9)]
        public string Isuf { get; set; }
        [Required]
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("XFANTASIA")]
        [StringLength(60)]
        public string Xfantasia { get; set; }
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
        [Column("CELULAR")]
        [StringLength(14)]
        public string Celular { get; set; }
        [Column("EMAIL")]
        [StringLength(60)]
        public string Email { get; set; }
        [Column("SITE")]
        [StringLength(256)]
        public string Site { get; set; }
        [Column("ISSRETIDO")]
        public int? Issretido { get; set; }
        [Column("CLIENTE")]
        public int Cliente { get; set; }
        [Column("FORNECEDOR")]
        public int Fornecedor { get; set; }
        [Column("TRANSPORTADORA")]
        public int Transportadora { get; set; }
        [Column("COLABORADOR")]
        public int? Colaborador { get; set; }
        [Column("MOTORISTA")]
        public int? Motorista { get; set; }
        [Column("ASSOCIADO")]
        public int? Associado { get; set; }
        [Column("IND_NAT_RET")]
        [StringLength(2)]
        public string IndNatRet { get; set; }
        [Column("STATUS_PESSOA")]
        public int? StatusPessoa { get; set; }
        [Column("BLOQUEADO")]
        public int? Bloqueado { get; set; }
        [Column("OBSERVACAO")]
        [StringLength(1024)]
        public string Observacao { get; set; }
        [Column("DATA_NASCIMENTO")]
        public DateTime? DataNascimento { get; set; }
        [Column("CPAIS_NATAL")]
        [StringLength(4)]
        public string CpaisNatal { get; set; }
        [Column("CUF_NATAL")]
        [StringLength(2)]
        public string CufNatal { get; set; }
        [Column("CMUN_NATAL")]
        [StringLength(7)]
        public string CmunNatal { get; set; }
        [Column("XPAIS_NATAL")]
        [StringLength(60)]
        public string XpaisNatal { get; set; }
        [Column("XUF_NATAL")]
        [StringLength(60)]
        public string XufNatal { get; set; }
        [Column("XMUN_NATAL")]
        [StringLength(60)]
        public string XmunNatal { get; set; }
        [Column("TAGS")]
        [StringLength(256)]
        public string Tags { get; set; }
    }
}
