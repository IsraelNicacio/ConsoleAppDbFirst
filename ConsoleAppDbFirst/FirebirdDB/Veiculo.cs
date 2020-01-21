using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("VEICULO                        ")]
    public partial class Veiculo
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("CINTERNO")]
        [StringLength(10)]
        public string Cinterno { get; set; }
        [Required]
        [Column("RENAVAM")]
        [StringLength(11)]
        public string Renavam { get; set; }
        [Required]
        [Column("PLACA")]
        [StringLength(7)]
        public string Placa { get; set; }
        [Required]
        [Column("TARA")]
        [StringLength(6)]
        public string Tara { get; set; }
        [Column("CAPKG")]
        public int Capkg { get; set; }
        [Column("CAPM3")]
        public int Capm3 { get; set; }
        [Required]
        [Column("TPPROP")]
        [StringLength(1)]
        public string Tpprop { get; set; }
        [Required]
        [Column("TPVEIC")]
        [StringLength(1)]
        public string Tpveic { get; set; }
        [Required]
        [Column("TPROD")]
        [StringLength(2)]
        public string Tprod { get; set; }
        [Required]
        [Column("TPCAR")]
        [StringLength(2)]
        public string Tpcar { get; set; }
        [Required]
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("EMITCTE")]
        public int Emitcte { get; set; }
        [Column("CPFCNPJ")]
        [StringLength(14)]
        public string Cpfcnpj { get; set; }
        [Column("RNTRC")]
        [StringLength(8)]
        public string Rntrc { get; set; }
        [Column("XNOME")]
        [StringLength(60)]
        public string Xnome { get; set; }
        [Column("IE")]
        [StringLength(14)]
        public string Ie { get; set; }
        [Column("UFPROP")]
        [StringLength(2)]
        public string Ufprop { get; set; }
        [Column("TPPROPI")]
        [StringLength(1)]
        public string Tppropi { get; set; }
    }
}
