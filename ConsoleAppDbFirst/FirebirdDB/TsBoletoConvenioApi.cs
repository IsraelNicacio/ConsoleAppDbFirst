using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("TS_BOLETO_CONVENIO_API         ")]
    public partial class TsBoletoConvenioApi
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NUMERO_CONVENIO")]
        [StringLength(32)]
        public string NumeroConvenio { get; set; }
        [Column("DESCRICAO_CONVENIO")]
        [StringLength(256)]
        public string DescricaoConvenio { get; set; }
        [Column("CARTEIRA")]
        [StringLength(8)]
        public string Carteira { get; set; }
        [Column("ESPECIE")]
        [StringLength(16)]
        public string Especie { get; set; }
        [Column("ID_CONTA")]
        public int IdConta { get; set; }
        [Column("CRIADO")]
        public DateTime? Criado { get; set; }
        [Column("ATUALIZADO")]
        public DateTime? Atualizado { get; set; }
        [Column("PADRAO_CNAB")]
        [StringLength(8)]
        public string PadraoCnab { get; set; }
        [Column("UTILIZA_VAN")]
        public short? UtilizaVan { get; set; }
        [Column("NUMERO_REMESSA")]
        [StringLength(32)]
        public string NumeroRemessa { get; set; }
        [Column("JSON", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Json { get; set; }
        [Column("CRIACAO_USUARIO_ID")]
        public int? CriacaoUsuarioId { get; set; }
        [Column("CRIACAO_DATA_HORA")]
        public DateTime? CriacaoDataHora { get; set; }
        [Column("ULTIMA_ATUALIZACAO_USUARIO_ID")]
        public int? UltimaAtualizacaoUsuarioId { get; set; }
        [Column("ULTIMA_ATUALIZACAO_DATA_HORA")]
        public DateTime? UltimaAtualizacaoDataHora { get; set; }
    }
}
