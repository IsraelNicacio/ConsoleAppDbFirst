using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_ICMSTOT         ")]
    public partial class NotafiscalXmlIcmstot
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal Vbc { get; set; }
        [Column("VICMS", TypeName = "DECIMAL(15, 2)")]
        public decimal Vicms { get; set; }
        [Column("VICMSDESON", TypeName = "DECIMAL(15, 2)")]
        public decimal Vicmsdeson { get; set; }
        [Column("VFCP", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vfcp { get; set; }
        [Column("VFCPUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vfcpufdest { get; set; }
        [Column("VICMSUFDEST", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vicmsufdest { get; set; }
        [Column("VICMSUFREMET", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vicmsufremet { get; set; }
        [Column("VBCST", TypeName = "DECIMAL(15, 2)")]
        public decimal Vbcst { get; set; }
        [Column("VST", TypeName = "DECIMAL(15, 2)")]
        public decimal Vst { get; set; }
        [Column("VFCPST", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vfcpst { get; set; }
        [Column("VFCPSTRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vfcpstret { get; set; }
        [Column("VPROD", TypeName = "DECIMAL(15, 2)")]
        public decimal Vprod { get; set; }
        [Column("VFRETE", TypeName = "DECIMAL(15, 2)")]
        public decimal Vfrete { get; set; }
        [Column("VSEG", TypeName = "DECIMAL(15, 2)")]
        public decimal Vseg { get; set; }
        [Column("VDESC", TypeName = "DECIMAL(15, 2)")]
        public decimal Vdesc { get; set; }
        [Column("VII", TypeName = "DECIMAL(15, 2)")]
        public decimal Vii { get; set; }
        [Column("VIPI", TypeName = "DECIMAL(15, 2)")]
        public decimal Vipi { get; set; }
        [Column("VIPIDEVOL", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vipidevol { get; set; }
        [Column("VPIS", TypeName = "DECIMAL(15, 2)")]
        public decimal Vpis { get; set; }
        [Column("VCOFINS", TypeName = "DECIMAL(15, 2)")]
        public decimal Vcofins { get; set; }
        [Column("VOUTRO", TypeName = "DECIMAL(15, 2)")]
        public decimal Voutro { get; set; }
        [Column("VNF", TypeName = "DECIMAL(15, 2)")]
        public decimal Vnf { get; set; }
        [Column("VTOTTRIB", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vtottrib { get; set; }
    }
}
