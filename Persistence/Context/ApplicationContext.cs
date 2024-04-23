using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Platos> Platos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Mesas> Mesas { get; set; }
        public DbSet<PlatosIngrediente> PlatosIngredientes { get; set; }
        public DbSet<OrdenesPlatos> OrdenesPlatos { get; set; }
        public DbSet<OrdenMesa> OrdenMesas { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<Auditable>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<Ordenes>()
            .ToTable("Ordenes");

            modelBuilder.Entity<Platos>()
                .ToTable("Platos");


            modelBuilder.Entity<Mesas>()
                .ToTable("Mesas");

            modelBuilder.Entity<Ingrediente>()
                .ToTable("Ingredientes");


            modelBuilder.Entity<OrdenesPlatos>()
                .ToTable("OrdenPlatos");

            modelBuilder.Entity<PlatosIngrediente>()
                .ToTable("PlatoIngredientes");

            #endregion

            #region Primary key
            modelBuilder.Entity<Ordenes>()
                .HasKey(x=>x.Id);

            modelBuilder.Entity<Platos>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Mesas>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Ingrediente>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<PlatosIngrediente>()
            .HasKey(pi => new { pi.PlatoId, pi.IngredienteId });

        modelBuilder.Entity<OrdenesPlatos>()
            .HasKey(op => new { op.OrdenId, op.PlatoId });

        modelBuilder.Entity<OrdenMesa>()
            .HasKey(om => new { om.OrdenId, om.MesaId });
            #endregion

            #region Relaciones


            modelBuilder.Entity<OrdenMesa>()
       .HasKey(om => new { om.OrdenId, om.MesaId });
            modelBuilder.Entity<OrdenMesa>()
                .HasOne(om => om.Orden)
                .WithMany(o => o.OrdenMesa)
                .HasForeignKey(om => om.OrdenId)
                .OnDelete(DeleteBehavior.NoAction); // Cambiar a NoAction

            modelBuilder.Entity<OrdenMesa>()
                .HasOne(om => om.Mesa)
                .WithMany(m => m.OrdenMesa)
                .HasForeignKey(om => om.MesaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Platos>()
           .HasMany(p => p.PlatosIngrediente)
           .WithOne(pi => pi.Plato)
           .HasForeignKey(pi => pi.PlatoId)
           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ingrediente>()
                .HasMany(i => i.PlatosIngrediente)
                .WithOne(pi => pi.Ingrediente)
                .HasForeignKey(pi => pi.IngredienteId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ordenes>()
                .HasMany(o => o.OrdenesPlatos)
                .WithOne(op => op.Orden)
                .HasForeignKey(op => op.OrdenId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Platos>()
                .HasMany(p => p.OrdenesPlatos)
                .WithOne(op => op.Plato)
                .HasForeignKey(op => op.PlatoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Ordenes>()
                .HasMany(o => o.OrdenMesa)
                .WithOne(om => om.Orden)
                .HasForeignKey(om => om.OrdenId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Mesas>()
                .HasMany(m => m.OrdenMesa)
                .WithOne(om => om.Mesa)
                .HasForeignKey(om => om.MesaId)
                .OnDelete(DeleteBehavior.NoAction);





            #endregion
        }
    }
}
