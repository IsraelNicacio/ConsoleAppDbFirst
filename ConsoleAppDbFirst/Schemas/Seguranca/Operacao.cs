using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    [Table("Operacao", Schema = "Seguranca")]
    public partial class Operacao
    {
        public Operacao()
        {
            Permissao = new HashSet<Permissao>();
        }

        public int Id { get; set; }
        public int FuncionalidadeId { get; set; }
        [Required]
        [StringLength(256)]
        public string Descricao { get; set; }

        [ForeignKey("FuncionalidadeId")]
        [InverseProperty("Operacao")]
        public virtual Funcionalidade Funcionalidade { get; set; }
        [InverseProperty("Operacao")]
        public virtual ICollection<Permissao> Permissao { get; set; }
    }
}
