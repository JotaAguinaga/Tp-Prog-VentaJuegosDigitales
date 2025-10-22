using Clases;
using ClasesTienda.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_clases.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoProducto> PedidoProductos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=Venta_JuegosOnline;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Envio)
                .WithOne(e => e.Pedido)
                .HasForeignKey<Envio>(e => e.PedidoId);


            modelBuilder.Entity<PedidoProducto>()
                .HasKey(pp => new { pp.Id, pp.IdProducto });


            modelBuilder.Entity<PedidoProducto>()
                .HasOne(pp => pp.Pedido)
                .WithMany(p => p.PedidoProductos)
                .HasForeignKey(pp => pp.Id);

            modelBuilder.Entity<PedidoProducto>()
                .HasOne(pp => pp.Producto)
                .WithMany()
                .HasForeignKey(pp => pp.IdProducto);

            // ✅ Esta línea nueva
            modelBuilder.Entity<Envio>()
                .HasKey(e => e.Id);
        }

    }
}