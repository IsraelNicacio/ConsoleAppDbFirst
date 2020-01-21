using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Funcionalidade", Schema = "Seguranca")]
    public partial class Funcionalidade
    {
        public Funcionalidade()
        {
            Operacao = new HashSet<Operacao>();
        }

        public int Id { get; set; }
        public short ModuloId { get; set; }
        public short Tipo { get; set; }
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }

        [ForeignKey("ModuloId")]
        [InverseProperty("Funcionalidade")]
        public virtual Modulo Modulo { get; set; }
        [InverseProperty("Funcionalidade")]
        public virtual ICollection<Operacao> Operacao { get; set; }
    }
}
