using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONTABILISTA                   ")]
    public partial class Contabilista
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Required]
        [Column("CPF")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [Column("CRC")]
        [StringLength(15)]
        public string Crc { get; set; }
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Required]
        [Column("XLOGR")]
        [StringLength(60)]
        public string Xlogr { get; set; }
        [Required]
        [Column("NUM")]
        [StringLength(10)]
        public string Num { get; set; }
        [Column("XCOMPL")]
        [StringLength(60)]
        public string Xcompl { get; set; }
        [Required]
        [Column("XBAIRRO")]
        [StringLength(60)]
        public string Xbairro { get; set; }
        [Column("CEP")]
        [StringLength(8)]
        public string Cep { get; set; }
        [Required]
        [Column("CMUN")]
        [StringLength(7)]
        public string Cmun { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(60)]
        public string Email { get; set; }
        [Column("FONE")]
        [StringLength(14)]
        public string Fone { get; set; }
        [Column("FAX")]
        [StringLength(14)]
        public string Fax { get; set; }
    }
}
