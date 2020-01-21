using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_ISSQNTOT        ")]
    public partial class NotafiscalXmlIssqntot
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("VSERV", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vserv { get; set; }
        [Column("VBC", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vbc { get; set; }
        [Column("VISS", TypeName = "DECIMAL(15, 2)")]
        public decimal? Viss { get; set; }
        [Column("VPIS", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vpis { get; set; }
        [Column("VCOFINS", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vcofins { get; set; }
        [Column("DCOMPET")]
        public DateTime? Dcompet { get; set; }
        [Column("VDEDUCAO", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdeducao { get; set; }
        [Column("VOUTRO", TypeName = "DECIMAL(15, 2)")]
        public decimal? Voutro { get; set; }
        [Column("VDESCINCOND", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdescincond { get; set; }
        [Column("VDESCCOND", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vdesccond { get; set; }
        [Column("VISSRET", TypeName = "DECIMAL(15, 2)")]
        public decimal? Vissret { get; set; }
        [Column("CREGTRIB")]
        public int? Cregtrib { get; set; }
    }
}
