using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_IMPOSTO                ")]
    public partial class CteXmlImposto
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("ICMS_CST")]
        [StringLength(4)]
        public string IcmsCst { get; set; }
        [Column("ICMS_PREDBC", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsPredbc { get; set; }
        [Column("ICMS_VBC", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsVbc { get; set; }
        [Column("ICMS_PICMS", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsPicms { get; set; }
        [Column("ICMS_VICMS", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsVicms { get; set; }
        [Column("ICMS_VCRED", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsVcred { get; set; }
        [Column("VTOTTRIB", TypeName = "DECIMAL(13, 2)")]
        public decimal? Vtottrib { get; set; }
        [Column("INFADFISCO")]
        public string Infadfisco { get; set; }
        [Column("INDSN")]
        public int? Indsn { get; set; }
        [Column("ICMSUFFIM_VBCUFFIM", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsuffimVbcuffim { get; set; }
        [Column("ICMSUFFIM_PFCPUFFIM", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsuffimPfcpuffim { get; set; }
        [Column("ICMSUFFIM_PICMSUFFIM", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsuffimPicmsuffim { get; set; }
        [Column("ICMSUFFIM_PICMSINTER", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsuffimPicmsinter { get; set; }
        [Column("ICMSUFFIM_PICMSINTERPART", TypeName = "DECIMAL(3, 2)")]
        public decimal? IcmsuffimPicmsinterpart { get; set; }
        [Column("ICMSUFFIM_VFCPUFFIM", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsuffimVfcpuffim { get; set; }
        [Column("ICMSUFFIM_VICMSUFFIM", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsuffimVicmsuffim { get; set; }
        [Column("ICMSUFFIM_VICMSUFINI", TypeName = "DECIMAL(13, 2)")]
        public decimal? IcmsuffimVicmsufini { get; set; }
    }
}
