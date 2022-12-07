using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnviosTLE.Models
{
    public partial class ContextoTLE : DbContext
    {
        public ContextoTLE() : base("name=ContextoTLE")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.ID_CLIENTE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.IDENTIFICACION)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.NOMBRES)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.APELLIDOS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.DIRECCION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.TELEFONO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.TIPO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CLIENTE>()
        //        .Property(e => e.ID_FACTURA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FACTURA>()
        //        .Property(e => e.ID_FACTURA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FACTURA>()
        //        .Property(e => e.VALOR)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<FACTURA>()
        //        .HasMany(e => e.CLIENTE)
        //        .WithRequired(e => e.FACTURA)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<FACTURA>()
        //        .HasMany(e => e.PRODUCTO)
        //        .WithRequired(e => e.FACTURA)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.ID_PRODUCTO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.PESO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.ALTO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.ANCHO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.LARGO)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.DESCRIPCION)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<PRODUCTO>()
        //        .Property(e => e.ID_FACTURA)
        //        .IsUnicode(false);
        //}
    }
}
