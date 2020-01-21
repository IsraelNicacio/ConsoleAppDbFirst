using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TAG                            ")]
    public partial class Tag
    {
        [Column("TABELA")]
        [StringLength(32)]
        public string Tabela { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
        [Column("BACKCOLOR")]
        [StringLength(32)]
        public string Backcolor { get; set; }
        [Column("FORECOLOR")]
        [StringLength(32)]
        public string Forecolor { get; set; }
        [Column("CUSTOM")]
        public short Custom { get; set; }
    }
}
