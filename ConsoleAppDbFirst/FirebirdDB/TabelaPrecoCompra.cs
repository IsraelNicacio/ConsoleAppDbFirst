using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TABELA_PRECO_COMPRA            ")]
    public partial class TabelaPrecoCompra
    {
        [Column("PESSOA_ID")]
        public long PessoaId { get; set; }
        [Column("CPROD")]
        [StringLength(60)]
        public string Cprod { get; set; }
        [Column("VALOR", TypeName = "DECIMAL(18, 3)")]
        public decimal Valor { get; set; }
        [Column("DATA_ATUALIZACAO", TypeName = "DATE")]
        public DateTime? DataAtualizacao { get; set; }
    }
}
