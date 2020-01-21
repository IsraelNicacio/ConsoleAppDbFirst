using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_XML_RODO_VEICULO           ")]
    public partial class CteXmlRodoVeiculo
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public short Numero { get; set; }
        [Column("CINT")]
        [StringLength(10)]
        public string Cint { get; set; }
        [Column("RENAVAM")]
        [StringLength(11)]
        public string Renavam { get; set; }
        [Column("PLACA")]
        [StringLength(7)]
        public string Placa { get; set; }
        [Column("TARA")]
        [StringLength(6)]
        public string Tara { get; set; }
        [Column("CAPKG")]
        [StringLength(6)]
        public string Capkg { get; set; }
        [Column("CAPM3")]
        [StringLength(3)]
        public string Capm3 { get; set; }
        [Column("TPPROP")]
        [StringLength(2)]
        public string Tpprop { get; set; }
        [Column("TPVEIC")]
        [StringLength(2)]
        public string Tpveic { get; set; }
        [Column("TPROD")]
        [StringLength(2)]
        public string Tprod { get; set; }
        [Column("TPCAR")]
        [StringLength(2)]
        public string Tpcar { get; set; }
        [Column("UF")]
        [StringLength(2)]
        public string Uf { get; set; }
        [Column("PROP_CNPJ_CPF")]
        [StringLength(14)]
        public string PropCnpjCpf { get; set; }
        [Column("PROP_RNTRC")]
        [StringLength(8)]
        public string PropRntrc { get; set; }
        [Column("PROP_XNOME")]
        [StringLength(60)]
        public string PropXnome { get; set; }
        [Column("PROP_IE")]
        [StringLength(14)]
        public string PropIe { get; set; }
        [Column("PROP_UF")]
        [StringLength(2)]
        public string PropUf { get; set; }
        [Column("PROP_TPPROP")]
        [StringLength(2)]
        public string PropTpprop { get; set; }
    }
}
