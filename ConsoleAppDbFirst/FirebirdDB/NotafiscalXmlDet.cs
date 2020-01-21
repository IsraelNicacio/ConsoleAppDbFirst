using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_DET             ")]
    public partial class NotafiscalXmlDet
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NITEM")]
        public int Nitem { get; set; }
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("CEAN")]
        [StringLength(14)]
        public string Cean { get; set; }
        [Column("XPROD")]
        [StringLength(120)]
        public string Xprod { get; set; }
        [Column("NCM")]
        [StringLength(8)]
        public string Ncm { get; set; }
        [Column("EXTIPI")]
        [StringLength(3)]
        public string Extipi { get; set; }
        [Column("CEST")]
        [StringLength(7)]
        public string Cest { get; set; }
        [Column("CFOP")]
        [StringLength(4)]
        public string Cfop { get; set; }
        [Column("UCOM")]
        [StringLength(6)]
        public string Ucom { get; set; }
        [Column("QCOM", TypeName = "DECIMAL(15, 4)")]
        public decimal? Qcom { get; set; }
        [Column("VUNCOM", TypeName = "DECIMAL(18, 4)")]
        public decimal? Vuncom { get; set; }
        [Column("VPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vprod { get; set; }
        [Column("CEANTRIB")]
        [StringLength(14)]
        public string Ceantrib { get; set; }
        [Column("UTRIB")]
        [StringLength(6)]
        public string Utrib { get; set; }
        [Column("QTRIB", TypeName = "DECIMAL(15, 4)")]
        public decimal? Qtrib { get; set; }
        [Column("VUNTRIB", TypeName = "DECIMAL(18, 4)")]
        public decimal? Vuntrib { get; set; }
        [Column("VFRETE", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vfrete { get; set; }
        [Column("VSEG", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vseg { get; set; }
        [Column("VDESC", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdesc { get; set; }
        [Column("VOUTRO", TypeName = "DECIMAL(15, 2)")]
        public decimal? Voutro { get; set; }
        [Column("INDTOT")]
        public int? Indtot { get; set; }
        [Column("INFADPROD")]
        [StringLength(500)]
        public string Infadprod { get; set; }
    }
}
