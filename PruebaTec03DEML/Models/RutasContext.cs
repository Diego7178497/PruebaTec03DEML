using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaTec03DEML.Models
{
    public partial class RutasContext : DbContext
    {
        public RutasContext()
        {
        }

        public RutasContext(DbContextOptions<RutasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ruta> Rutas { get; set; } = null!;
        public virtual DbSet<bus> Buses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<bus>(entity =>
            {
                entity.HasKey(e => e.AutobusId)
                    .HasName("PK__Buses__92B9282EAF0330E2");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Modelo).HasMaxLength(100);

                entity.Property(e => e.Placa).HasMaxLength(20);

                entity.HasOne(d => d.Ruta)
                    .WithMany(p => p.buses)
                    .HasForeignKey(d => d.RutaId)
                    .HasConstraintName("FK__Buses__RutaId__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
