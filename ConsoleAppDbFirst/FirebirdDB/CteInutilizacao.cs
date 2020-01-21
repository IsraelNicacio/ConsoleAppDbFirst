using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDbFirst.FirebirdDB
{
    [Table("CTE_INUTILIZACAO               ")]
    public partial class CteInutilizacao
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("TPAMB")]
        public int Tpamb { get; set; }
        [Column("CUF")]
        public int Cuf { get; set; }
        [Column("ANO")]
        public int Ano { get; set; }
        [Required]
        [Column("CNPJ")]
        [StringLength(14)]
        public string Cnpj { get; set; }
        [Column("MOD")]
        public int Mod { get; set; }
        [Column("SERIE")]
        public int Serie { get; set; }
        [Column("NCTINI")]
        public int Nctini { get; set; }
        [Column("NCTFIN")]
        public int Nctfin { get; set; }
        [Required]
        [Column("XJUST")]
        [StringLength(255)]
        public string Xjust { get; set; }
        [Column("DHRECBTO", TypeName = "DATE")]
        public DateTime Dhrecbto { get; set; }
        [Required]
        [Column("NPROT")]
        [StringLength(15)]
        public string Nprot { get; set; }
        [Column("XMLENTRADA", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlentrada { get; set; }
        [Column("XMLRETORNO", TypeName = "BLOB SUB_TYPE TEXT")]
        public string Xmlretorno { get; set; }
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
