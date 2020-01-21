using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC310                        ")]
    public partial class Regc310
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUM_DOC_CANC")]
        public long NumDocCanc { get; set; }
    }
}
