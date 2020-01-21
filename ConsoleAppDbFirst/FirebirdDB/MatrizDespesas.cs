using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("MATRIZ_DESPESAS                ")]
    public partial class MatrizDespesas
    {
        [Column("ID")]
        public long Id { get; set; }
        [Required]
        [Column("CONDICAO_CFOP")]
        [StringLength(4)]
        public string CondicaoCfop { get; set; }
        [Column("CONDICAO_CST_ICMS")]
        [StringLength(3)]
        public string CondicaoCstIcms { get; set; }
        [Required]
        [Column("ESCRITA_COD_ITEM")]
        [StringLength(60)]
        public string EscritaCodItem { get; set; }
        [Required]
        [Column("ESCRITA_CFOP")]
        [StringLength(4)]
        public string EscritaCfop { get; set; }
        [Required]
        [Column("ESCRITA_CST_ICMS")]
        [StringLength(3)]
        public string EscritaCstIcms { get; set; }
        [Column("ESCRITA_CST_IPI")]
        [StringLength(3)]
        public string EscritaCstIpi { get; set; }
        [Required]
        [Column("ESCRITA_CST_PIS")]
        [StringLength(3)]
        public string EscritaCstPis { get; set; }
        [Required]
        [Column("ESCRITA_CST_COFINS")]
        [StringLength(3)]
        public string EscritaCstCofins { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
    }
}
