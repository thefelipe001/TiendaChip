using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.Entity
{
    public partial class ApplicationDB : DbContext
    {
        public ApplicationDB()
            : base("name=ApplicationDB")
        {
        }

        public virtual DbSet<Chip> Chip { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chip>()
                .Property(e => e.Numero)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Chip>()
                .Property(e => e.Pink)
                .IsFixedLength();

            modelBuilder.Entity<Chip>()
                .Property(e => e.Punk)
                .IsFixedLength();

            modelBuilder.Entity<Chip>()
                .Property(e => e.Compañia)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);
        }
    }
}
