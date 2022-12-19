using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LanchesMac.Data
{
    public partial class LanchesDatabaseContext : DbContext
    {
        public LanchesDatabaseContext()
        {
        }

        public LanchesDatabaseContext(DbContextOptions<LanchesDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarrinhoCompraIten> CarrinhoCompraItens { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Lanch> Lanches { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=TuanKiet;Initial Catalog=LanchesDatabase4;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarrinhoCompraIten>(entity =>
            {
                entity.HasKey(e => e.CarrinhoCompraItemId);

                entity.HasIndex(e => e.LancheId, "IX_CarrinhoCompraItens_LancheId");

                entity.Property(e => e.CarrinhoCompraId).HasMaxLength(200);

                entity.HasOne(d => d.Lanche)
                    .WithMany(p => p.CarrinhoCompraItens)
                    .HasForeignKey(d => d.LancheId);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.CategoriaNome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Lanch>(entity =>
            {
                entity.HasKey(e => e.LancheId)
                    .HasName("PK_Lanche");

                entity.HasIndex(e => e.CategoriaId, "IX_Lanche_CategoriaId");

                entity.Property(e => e.DescricaoCurta)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DescricaoDetalhada)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ImagemThumbnailUrl).HasMaxLength(200);

                entity.Property(e => e.ImagemUrl).HasMaxLength(200);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Preco).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Lanches)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("FK_Lanche_Categorias_CategoriaId");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Cidade).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Endereco1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Endereco2).HasMaxLength(100);

                entity.Property(e => e.Estado).HasMaxLength(10);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PedidoTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<PedidoDetalhe>(entity =>
            {
                entity.HasIndex(e => e.LancheId, "IX_PedidoDetalhes_LancheId");

                entity.HasIndex(e => e.PedidoId, "IX_PedidoDetalhes_PedidoId");

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Lanche)
                    .WithMany(p => p.PedidoDetalhes)
                    .HasForeignKey(d => d.LancheId);

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.PedidoDetalhes)
                    .HasForeignKey(d => d.PedidoId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
