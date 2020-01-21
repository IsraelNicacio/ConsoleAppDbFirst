using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleAppDbFirst.Schemas.Cadastro
{
    public partial class CadastroContext : DbContext
    {
        public CadastroContext()
        {
        }

        public CadastroContext(DbContextOptions<CadastroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contribuinte> Contribuinte { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Ibge> Ibge { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Servico> Servico { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<Versao> Versao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=InfoNFSeBeloHorizonte;User Id=postgres;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Contribuinte>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Contribuinte)
                    .HasForeignKey<Contribuinte>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contribuinte_01");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Ordem });

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_Email_01");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Tipo });

                entity.HasIndex(e => e.Cidade)
                    .HasName("IX_Endereco_01");

                entity.HasIndex(e => e.Estado)
                    .HasName("IX_Endereco_02");

                entity.HasIndex(e => e.Pais)
                    .HasName("IX_Endereco_03");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_Endereco_01");
            });

            modelBuilder.Entity<Ibge>(entity =>
            {
                entity.HasIndex(e => e.CMunicipio)
                    .HasName("IX_Ibge_03");

                entity.HasIndex(e => e.CUf)
                    .HasName("IX_Ibge_01");

                entity.HasIndex(e => e.XMunicipio)
                    .HasName("IX_Ibge_04");

                entity.HasIndex(e => e.XUf)
                    .HasName("IX_Ibge_02");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasIndex(e => e.Nome)
                    .HasName("IX_Pais_01");

                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasIndex(e => e.CodigoAuxiliar)
                    .HasName("IX_Pessoa_04");

                entity.HasIndex(e => e.CpfCnpj)
                    .HasName("IX_Pessoa_01");

                entity.HasIndex(e => e.InscricaoMunicipal)
                    .HasName("IX_Pessoa_02");

                entity.HasIndex(e => e.Nome)
                    .HasName("IX_Pessoa_03");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Cadastro\".\"Pessoa_Id_seq\"'::regclass)");

                entity.Property(e => e.IssRetido).HasDefaultValueSql("2");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_Servico_01");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Cadastro\".\"Servico_Id_seq\"'::regclass)");
            });

            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Tipo });

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Telefone)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_Telefone_01");
            });

            modelBuilder.Entity<Versao>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.HasSequence("Pessoa_Id_seq");

            modelBuilder.HasSequence("Servico_Id_seq");
        }
    }
}
