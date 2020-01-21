using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("ANALISTA_TRIBUTACAO            ")]
    public partial class AnalistaTributacao
    {
        [Column("ID_TRIBUTACAO")]
        public int IdTributacao { get; set; }
        [Column("CODIGO_TRIBUTACAO")]
        public int? CodigoTributacao { get; set; }
        [Column("NOME_TRIBUTACAO")]
        [StringLength(64)]
        public string NomeTributacao { get; set; }
        [Column("PRODUTO_UNID")]
        [StringLength(6)]
        public string ProdutoUnid { get; set; }
        [Column("PRODUTO_TIPO_ITEM")]
        [StringLength(2)]
        public string ProdutoTipoItem { get; set; }
        [Column("PRODUTO_GRUPO")]
        public int? ProdutoGrupo { get; set; }
        [Column("RECEITA_CST_PIS")]
        [StringLength(2)]
        public string ReceitaCstPis { get; set; }
        [Column("RECEITA_CST_COFINS")]
        [StringLength(2)]
        public string ReceitaCstCofins { get; set; }
        [Column("RECEITA_NAT_REC_PIS")]
        [StringLength(3)]
        public string ReceitaNatRecPis { get; set; }
        [Column("RECEITA_NAT_REC_COFINS")]
        [StringLength(3)]
        public string ReceitaNatRecCofins { get; set; }
        [Column("CREDITO_CST_PIS")]
        [StringLength(2)]
        public string CreditoCstPis { get; set; }
        [Column("CREDITO_CST_COFINS")]
        [StringLength(2)]
        public string CreditoCstCofins { get; set; }
        [Column("CREDITO_NAT_BC_CRED")]
        [StringLength(2)]
        public string CreditoNatBcCred { get; set; }
        [Column("CREDITO_IND_ORIG_CRED")]
        [StringLength(1)]
        public string CreditoIndOrigCred { get; set; }
        [Column("COD_CTA_RECEITA")]
        [StringLength(60)]
        public string CodCtaReceita { get; set; }
        [Column("COD_CTA_DESPESA")]
        [StringLength(60)]
        public string CodCtaDespesa { get; set; }
    }
}
