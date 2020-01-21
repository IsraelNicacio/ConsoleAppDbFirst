using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CENTRO_CUSTO_LUCRO             ")]
    public partial class CentroCustoLucro
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("PARENT_ID")]
        public long? ParentId { get; set; }
        [Column("INDICE")]
        public int? Indice { get; set; }
        [Column("CUSTO")]
        public short? Custo { get; set; }
        [Column("LUCRO")]
        public short? Lucro { get; set; }
        [Column("CODIGO")]
        [StringLength(64)]
        public string Codigo { get; set; }
        [Column("DESCRICAO")]
        [StringLength(256)]
        public string Descricao { get; set; }
    }
}
