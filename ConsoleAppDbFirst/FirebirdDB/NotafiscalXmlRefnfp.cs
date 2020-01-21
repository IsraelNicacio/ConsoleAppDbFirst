using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_REFNFP          ")]
    public partial class NotafiscalXmlRefnfp
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("NUMERO")]
        public long Numero { get; set; }
        [Column("CUF")]
        [StringLength(2)]
        public string Cuf { get; set; }
        [Column("AAMM")]
        [StringLength(4)]
        public string Aamm { get; set; }
        [Column("CPFCNPJ")]
        [StringLength(14)]
        public string Cpfcnpj { get; set; }
        [Column("IE")]
        [StringLength(16)]
        public string Ie { get; set; }
        [Column("MOD")]
        [StringLength(2)]
        public string Mod { get; set; }
        [Column("SERIE")]
        [StringLength(3)]
        public string Serie { get; set; }
        [Column("NNF")]
        [StringLength(9)]
        public string Nnf { get; set; }
    }
}
