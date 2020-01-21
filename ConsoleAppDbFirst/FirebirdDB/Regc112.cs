using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("REGC112                        ")]
    public partial class Regc112
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("C110_ID")]
        public int? C110Id { get; set; }
        [Column("C110_COD_INF")]
        [StringLength(6)]
        public string C110CodInf { get; set; }
        [Column("ANO")]
        public int Ano { get; set; }
        [Column("MES")]
        public int Mes { get; set; }
        [Required]
        [Column("COD_DA")]
        [StringLength(1)]
        public string CodDa { get; set; }
        [Required]
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("NUM_DA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string NumDa { get; set; }
        [Column("COD_AUT", TypeName = "BLOB SUB_TYPE TEXT")]
        public string CodAut { get; set; }
        [Column("VL_DA", TypeName = "DECIMAL(18, 2)")]
        public decimal VlDa { get; set; }
        [Column("DT_VCTO")]
        public DateTime DtVcto { get; set; }
        [Column("DT_PGTO")]
        public DateTime DtPgto { get; set; }
        [Required]
        [Column("NUM_BANCO")]
        [StringLength(6)]
        public string NumBanco { get; set; }
        [Required]
        [Column("NUM_AGENCIA")]
        [StringLength(4)]
        public string NumAgencia { get; set; }
        [Required]
        [Column("NUM_CONVENIO_PROTOCOLO")]
        [StringLength(30)]
        public string NumConvenioProtocolo { get; set; }
    }
}
