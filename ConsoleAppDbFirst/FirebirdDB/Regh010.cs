using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGH010                        ")]
    public partial class Regh010
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Required]
        [Column("COD_ITEM")]
        [StringLength(60)]
        public string CodItem { get; set; }
        [Required]
        [Column("UNID")]
        [StringLength(6)]
        public string Unid { get; set; }
        [Column("QTD", TypeName = "DECIMAL(18, 3)")]
        public decimal Qtd { get; set; }
        [Column("VL_UNIT", TypeName = "DECIMAL(18, 6)")]
        public decimal VlUnit { get; set; }
        [Column("VL_ITEM", TypeName = "DECIMAL(18, 2)")]
        public decimal VlItem { get; set; }
        [Required]
        [Column("IND_PROP")]
        [StringLength(2)]
        public string IndProp { get; set; }
        [Column("COD_PART")]
        public long? CodPart { get; set; }
        [Column("TXT_COMPL", TypeName = "BLOB SUB_TYPE TEXT")]
        public string TxtCompl { get; set; }
        [Column("COD_CTA")]
        [StringLength(60)]
        public string CodCta { get; set; }
        [Column("VL_ITEM_IR", TypeName = "DECIMAL(18, 2)")]
        public decimal? VlItemIr { get; set; }
    }
}
