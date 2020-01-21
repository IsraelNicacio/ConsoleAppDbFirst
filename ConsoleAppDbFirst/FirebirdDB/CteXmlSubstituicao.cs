using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_SUBSTITUICAO           ")]
    public partial class CteXmlSubstituicao
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CHCTE")]
        [StringLength(44)]
        public string Chcte { get; set; }
        [Column("REFCTEANU")]
        [StringLength(44)]
        public string Refcteanu { get; set; }
        [Column("TOMAICMS_REFNFE")]
        [StringLength(44)]
        public string TomaicmsRefnfe { get; set; }
        [Column("TOMAICMS_REFNF_CNPJ")]
        [StringLength(14)]
        public string TomaicmsRefnfCnpj { get; set; }
        [Column("TOMAICMS_REFNF_CPF")]
        [StringLength(11)]
        public string TomaicmsRefnfCpf { get; set; }
        [Column("TOMAICMS_REFNF_MOD")]
        [StringLength(2)]
        public string TomaicmsRefnfMod { get; set; }
        [Column("TOMAICMS_REFNF_SERIE")]
        public int? TomaicmsRefnfSerie { get; set; }
        [Column("TOMAICMS_REFNF_SUBSERIE")]
        public int? TomaicmsRefnfSubserie { get; set; }
        [Column("TOMAICMS_REFNF_NRO")]
        public int? TomaicmsRefnfNro { get; set; }
        [Column("TOMAICMS_REFNF_VALOR", TypeName = "DECIMAL(13, 2)")]
        public decimal? TomaicmsRefnfValor { get; set; }
        [Column("TOMAICMS_REFNF_DEMI")]
        public DateTime? TomaicmsRefnfDemi { get; set; }
        [Column("TOMAICMS_REFCTE")]
        [StringLength(44)]
        public string TomaicmsRefcte { get; set; }
    }
}
