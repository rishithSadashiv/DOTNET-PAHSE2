using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrderService.Models
{
    public partial class ShopDBContext : DbContext
    {
        public ShopDBContext()
        {
        }

        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SANTU\\MSSQLSERVER2019;Database=ShopDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Items__727E838B5431654E");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Items__737584F62F48FC00")
                    .IsUnique();

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BCFE91F5559");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Orders__ItemId__276EDEB3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
