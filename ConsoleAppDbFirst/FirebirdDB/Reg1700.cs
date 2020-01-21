using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG1700                        ")]
    public partial class Reg1700
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ANO")]
        public int Ano { get; set; }
        [Column("MES")]
        public int Mes { get; set; }
        [Required]
        [Column("COD_DISP")]
        [StringLength(2)]
        public string CodDisp { get; set; }
        [Required]
        [Column("COD_MOD")]
        [StringLength(2)]
        public string CodMod { get; set; }
        [Column("SER")]
        [StringLength(4)]
        public string Ser { get; set; }
        [Column("SUB")]
        [StringLength(3)]
        public string Sub { get; set; }
        [Column("NUM_DOC_INI")]
        public long NumDocIni { get; set; }
        [Column("NUM_DOC_FIN")]
        public long NumDocFin { get; set; }
        [Required]
        [Column("NUM_AUT")]
        [StringLength(60)]
        public string NumAut { get; set; }
    }
}
