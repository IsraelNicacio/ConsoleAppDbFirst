using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_DOCS_NF                ")]
    public partial class CteXmlDocsNf
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("NROMA")]
        [StringLength(20)]
        public string Nroma { get; set; }
        [Column("NPED")]
        [StringLength(20)]
        public string Nped { get; set; }
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("SERIE")]
        [StringLength(3)]
        public string Serie { get; set; }
        [Column("NDOC")]
        [StringLength(20)]
        public string Ndoc { get; set; }
        [Column("DEMI", TypeName = "DATE")]
        public DateTime? Demi { get; set; }
        [Column("VBC", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vbc { get; set; }
        [Column("VICMS", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vicms { get; set; }
        [Column("VBCST", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vbcst { get; set; }
        [Column("VST", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vst { get; set; }
        [Column("VPROD", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vprod { get; set; }
        [Column("VNF", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vnf { get; set; }
        [Column("NCFOP")]
        [StringLength(4)]
        public string Ncfop { get; set; }
        [Column("NPESO", TypeName = "DECIMAL(12, 3)")]
        public decimal? Npeso { get; set; }
        [Column("PIN")]
        [StringLength(9)]
        public string Pin { get; set; }
        [Column("DPREV", TypeName = "DATE")]
        public DateTime? Dprev { get; set; }
    }
}
