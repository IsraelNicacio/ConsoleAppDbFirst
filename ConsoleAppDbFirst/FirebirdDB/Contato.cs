using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CONTATO                        ")]
    public partial class Contato
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(256)]
        public string Nome { get; set; }
        [Column("FONE")]
        [StringLength(14)]
        public string Fone { get; set; }
        [Column("CEL")]
        [StringLength(14)]
        public string Cel { get; set; }
        [Column("EMAIL")]
        [StringLength(256)]
        public string Email { get; set; }
        [Column("DEPARTAMENTO_ID")]
        public int? DepartamentoId { get; set; }
        [Column("CARGO_ID")]
        public int? CargoId { get; set; }
    }
}
