using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG0500                        ")]
    public partial class Reg0500
    {
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
        [Required]
        [Column("NOME_CTA")]
        [StringLength(60)]
        public string NomeCta { get; set; }
        [Column("DT_ALT")]
        public DateTime DtAlt { get; set; }
        [Required]
        [Column("COD_NAT_CC")]
        [StringLength(2)]
        public string CodNatCc { get; set; }
        [Required]
        [Column("IND_CTA")]
        [StringLength(1)]
        public string IndCta { get; set; }
        [Column("NIVEL")]
        public int Nivel { get; set; }
        [Column("COD_CTA_REF")]
        [StringLength(60)]
        public string CodCtaRef { get; set; }
        [Column("CNPJ_EST")]
        [StringLength(14)]
        public string CnpjEst { get; set; }
    }
}
