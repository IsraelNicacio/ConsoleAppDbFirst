using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    [Table("Ibge", Schema = "Cadastro")]
    public partial class Ibge
    {
        public int Id { get; set; }
        [Required]
        [Column("cUf")]
        [StringLength(2)]
        public string CUf { get; set; }
        [Required]
        [Column("xUf")]
        [StringLength(128)]
        public string XUf { get; set; }
        [Required]
        [Column("cMesorregiao")]
        [StringLength(4)]
        public string CMesorregiao { get; set; }
        [Column("xMesorregiao")]
        [StringLength(128)]
        public string XMesorregiao { get; set; }
        [Required]
        [Column("cMicrorregiao")]
        [StringLength(5)]
        public string CMicrorregiao { get; set; }
        [Required]
        [Column("xMicrorregiao")]
        [StringLength(128)]
        public string XMicrorregiao { get; set; }
        [Required]
        [Column("cMunicipio")]
        [StringLength(5)]
        public string CMunicipio { get; set; }
        [Required]
        [Column("xMunicipio")]
        [StringLength(256)]
        public string XMunicipio { get; set; }
        [Required]
        [Column("cDistrito")]
        [StringLength(2)]
        public string CDistrito { get; set; }
        [Required]
        [Column("xDistrito")]
        [StringLength(256)]
        public string XDistrito { get; set; }
        [Column("cSubdistrito")]
        [StringLength(2)]
        public string CSubdistrito { get; set; }
        [Column("xSubdistrito")]
        [StringLength(128)]
        public string XSubdistrito { get; set; }
    }
}
