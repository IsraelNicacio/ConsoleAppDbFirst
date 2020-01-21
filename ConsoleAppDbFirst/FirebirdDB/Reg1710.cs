using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REG1710                        ")]
    public partial class Reg1710
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_DOC_INI")]
        public long NumDocIni { get; set; }
        [Column("NUM_DOC_FIN")]
        public long NumDocFin { get; set; }
    }
}
