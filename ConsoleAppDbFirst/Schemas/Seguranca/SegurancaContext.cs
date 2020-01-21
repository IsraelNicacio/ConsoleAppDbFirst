using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleAppDbFirst.Schemas.Seguranca
{
    public partial class SegurancaContext : DbContext
    {
        public SegurancaContext()
        {
        }

        public SegurancaContext(DbContextOptions<SegurancaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Funcionalidade> Funcionalidade { get; set; }
        public virtual DbSet<GrupoUsuario> GrupoUsuario { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Operacao> Operacao { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
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

            modelBuilder.Entity<Funcionalidade>(entity =>
            {
                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_Funcionalidade_03");

                entity.HasIndex(e => e.ModuloId)
                    .HasName("IX_Funcionalidade_01");

                entity.HasIndex(e => e.Tipo)
                    .HasName("IX_Funcionalidade_02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.Funcionalidade)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Funcionalidade_01");
            });

            modelBuilder.Entity<GrupoUsuario>(entity =>
            {
                entity.HasIndex(e => e.Ativo)
                    .HasName("IX_GrupoUsuario_02");

                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_GrupoUsuario_01");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Seguranca\".\"GrupoUsuario_Id_seq\"'::regclass)");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_Modulo_01");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Operacao>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.FuncionalidadeId });

                entity.HasIndex(e => e.Descricao)
                    .HasName("IX_Operacao_02");

                entity.HasIndex(e => e.FuncionalidadeId)
                    .HasName("IX_Operacao_01");

                entity.HasOne(d => d.Funcionalidade)
                    .WithMany(p => p.Operacao)
                    .HasForeignKey(d => d.FuncionalidadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operacao_01");
            });

            modelBuilder.Entity<Permissao>(entity =>
            {
                entity.HasKey(e => new { e.GrupoUsuarioId, e.OperacaoId, e.FuncionalidadeId });

                entity.HasOne(d => d.GrupoUsuario)
                    .WithMany(p => p.Permissao)
                    .HasForeignKey(d => d.GrupoUsuarioId)
                    .HasConstraintName("FK_Permissao_01");

                entity.HasOne(d => d.Operacao)
                    .WithMany(p => p.Permissao)
                    .HasForeignKey(d => new { d.OperacaoId, d.FuncionalidadeId })
                    .HasConstraintName("FK_Permissao_02");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.Ativo)
                    .HasName("IX_Usuario_02");

                entity.HasIndex(e => e.Bloqueado)
                    .HasName("IX_Usuario_03");

                entity.HasIndex(e => e.GrupoUsuarioId)
                    .HasName("IX_Usuario_04");

                entity.HasIndex(e => e.Nome)
                    .HasName("IX_Usuario_01");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Seguranca\".\"Usuario_Id_seq\"'::regclass)");

                entity.HasOne(d => d.GrupoUsuario)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.GrupoUsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_01");
            });

            modelBuilder.Entity<Versao>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.HasSequence("GrupoUsuario_Id_seq").StartsAt(2);

            modelBuilder.HasSequence("Usuario_Id_seq").StartsAt(3);
        }
    }
}
