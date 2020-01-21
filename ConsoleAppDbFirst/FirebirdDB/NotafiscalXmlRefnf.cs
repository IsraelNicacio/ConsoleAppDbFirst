using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("NOTAFISCAL_XML_REFNF           ")]
    public partial class NotafiscalXmlRefnf
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
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
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
