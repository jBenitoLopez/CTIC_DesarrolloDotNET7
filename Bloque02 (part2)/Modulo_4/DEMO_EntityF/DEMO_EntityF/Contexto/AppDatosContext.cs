using System;
using DEMO_EntityF.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DEMO_EntityF.Contexto
{
    public partial class AppDatosContext : DbContext
    {
        public AppDatosContext()
        {
        }

        public AppDatosContext(DbContextOptions<AppDatosContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Encrypt=false;Persist Security Info=True;Integrated Security=True;Initial Catalog=AppDatos;Server=BPO2204-408\\SQL2019");
            }
        }

        public virtual DbSet<Comercial> Comercial { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<DireccionEmail> DireccionEmail { get; set; }
        public virtual DbSet<FormaEnvio> FormaEnvio { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<PedidoVenta> PedidoVenta { get; set; }
        public virtual DbSet<PedidoVentaDetalle> PedidoVentaDetalle { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoCategoria> ProductoCategoria { get; set; }
        public virtual DbSet<ProductoInventario> ProductoInventario { get; set; }
        public virtual DbSet<ProductoModelo> ProductoModelo { get; set; }
        public virtual DbSet<ProductoSubcategoria> ProductoSubcategoria { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comercial>(entity =>
            {
                entity.HasKey(e => e.PersonaId);

                entity.Property(e => e.PersonaId)
                    .HasColumnName("PersonaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus).HasColumnType("money");

                entity.Property(e => e.CuotaVentas).HasColumnType("money");

                entity.Property(e => e.PorcentajeComision).HasColumnType("smallmoney");

                entity.HasOne(d => d.Persona)
                    .WithOne(p => p.Comercial)
                    .HasForeignKey<Comercial>(d => d.PersonaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasIndex(e => e.ClienteId);

                entity.HasIndex(e => e.ProvinciaId);

                entity.Property(e => e.DireccionId).HasColumnName("DireccionID");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Linea2).HasMaxLength(60);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Direccion)
                    .HasForeignKey(d => d.ClienteId);

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Direccion)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DireccionEmail>(entity =>
            {
                entity.HasIndex(e => e.PersonaId);

                entity.Property(e => e.DireccionEmailId).HasColumnName("DireccionEmailID");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.DireccionEmail)
                    .HasForeignKey(d => d.PersonaId);
            });

            modelBuilder.Entity<FormaEnvio>(entity =>
            {
                entity.Property(e => e.FormaEnvioId).HasColumnName("FormaEnvioID");

                entity.Property(e => e.Coste).HasColumnType("money");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.PaisId)
                    .HasColumnName("PaisID")
                    .HasMaxLength(3);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PedidoVenta>(entity =>
            {
                entity.HasIndex(e => e.ClienteId);

                entity.HasIndex(e => e.ComercialId);

                entity.HasIndex(e => e.DireccionEnvioId);

                entity.HasIndex(e => e.DireccionFacturacionId);

                entity.HasIndex(e => e.FormaEnvioId);

                entity.HasIndex(e => e.TarjetaCreditoId);

                entity.Property(e => e.PedidoVentaId).HasColumnName("PedidoVentaID");

                entity.Property(e => e.ClienteId).HasColumnName("ClienteID");

                entity.Property(e => e.CodigoAutorizacion).HasMaxLength(15);

                entity.Property(e => e.Comentario).HasMaxLength(128);

                entity.Property(e => e.ComercialId).HasColumnName("ComercialID");

                entity.Property(e => e.DireccionEnvioId).HasColumnName("DireccionEnvioID");

                entity.Property(e => e.DireccionFacturacionId).HasColumnName("DireccionFacturacionID");

                entity.Property(e => e.Envio).HasColumnType("money");

                entity.Property(e => e.FormaEnvioId).HasColumnName("FormaEnvioID");

                entity.Property(e => e.ReferenciaCliente).HasMaxLength(25);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.TarjetaCreditoId).HasColumnName("TarjetaCreditoID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PedidoVenta)
                    .HasForeignKey(d => d.ClienteId);

                entity.HasOne(d => d.Comercial)
                    .WithMany(p => p.PedidoVenta)
                    .HasForeignKey(d => d.ComercialId);

                entity.HasOne(d => d.DireccionEnvio)
                    .WithMany(p => p.PedidoVentaDireccionEnvio)
                    .HasForeignKey(d => d.DireccionEnvioId);

                entity.HasOne(d => d.DireccionFacturacion)
                    .WithMany(p => p.PedidoVentaDireccionFacturacion)
                    .HasForeignKey(d => d.DireccionFacturacionId);

                entity.HasOne(d => d.FormaEnvio)
                    .WithMany(p => p.PedidoVenta)
                    .HasForeignKey(d => d.FormaEnvioId);

                entity.HasOne(d => d.TarjetaCredito)
                    .WithMany(p => p.PedidoVenta)
                    .HasForeignKey(d => d.TarjetaCreditoId);
            });

            modelBuilder.Entity<PedidoVentaDetalle>(entity =>
            {
                entity.HasIndex(e => e.PedidoVentaId);

                entity.HasIndex(e => e.ProductoId);

                entity.Property(e => e.PedidoVentaDetalleId).HasColumnName("PedidoVentaDetalleID");

                entity.Property(e => e.DescuentoPrecioUnitario).HasColumnType("money");

                entity.Property(e => e.NumeroSeguimiento).HasMaxLength(25);

                entity.Property(e => e.PedidoVentaId).HasColumnName("PedidoVentaID");

                entity.Property(e => e.PrecioUnitario).HasColumnType("money");

                entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

                entity.HasOne(d => d.PedidoVenta)
                    .WithMany(p => p.PedidoVentaDetalle)
                    .HasForeignKey(d => d.PedidoVentaId);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.PedidoVentaDetalle)
                    .HasForeignKey(d => d.ProductoId);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.EstadoCivil).HasMaxLength(1);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero).HasMaxLength(1);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroIdentificacion).HasMaxLength(15);

                entity.Property(e => e.Puesto).HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasIndex(e => e.ProductoModeloId);

                entity.HasIndex(e => e.ProductoSubcategoriaId);

                entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

                entity.Property(e => e.Coste).HasColumnType("money");

                entity.Property(e => e.Mpn)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioVenta).HasColumnType("money");

                entity.Property(e => e.ProductoModeloId).HasColumnName("ProductoModeloID");

                entity.Property(e => e.ProductoSubcategoriaId).HasColumnName("ProductoSubcategoriaID");

                entity.HasOne(d => d.ProductoModelo)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.ProductoModeloId);

                entity.HasOne(d => d.ProductoSubcategoria)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.ProductoSubcategoriaId);
            });

            modelBuilder.Entity<ProductoCategoria>(entity =>
            {
                entity.Property(e => e.ProductoCategoriaId).HasColumnName("ProductoCategoriaID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductoInventario>(entity =>
            {
                entity.HasKey(e => new { e.ProductoId, e.UbicacionId });

                entity.HasIndex(e => e.UbicacionId);

                entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.Shelf)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoInventario)
                    .HasForeignKey(d => d.ProductoId);

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.ProductoInventario)
                    .HasForeignKey(d => d.UbicacionId);
            });

            modelBuilder.Entity<ProductoModelo>(entity =>
            {
                entity.Property(e => e.ProductoModeloId).HasColumnName("ProductoModeloID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductoSubcategoria>(entity =>
            {
                entity.HasIndex(e => e.ProductoCategoriaId);

                entity.Property(e => e.ProductoSubcategoriaId).HasColumnName("ProductoSubcategoriaID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductoCategoriaId).HasColumnName("ProductoCategoriaID");

                entity.HasOne(d => d.ProductoCategoria)
                    .WithMany(p => p.ProductoSubcategoria)
                    .HasForeignKey(d => d.ProductoCategoriaId);
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasIndex(e => e.PaisId);

                entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

                entity.Property(e => e.CodigoProvincia)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("PaisID")
                    .HasMaxLength(3);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TarjetaCredito>(entity =>
            {
                entity.HasIndex(e => e.PersonaId);

                entity.Property(e => e.TarjetaCreditoId).HasColumnName("TarjetaCreditoID");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.TarjetaCredito)
                    .HasForeignKey(d => d.PersonaId);
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasIndex(e => e.PersonaId);

                entity.Property(e => e.TelefonoId).HasColumnName("TelefonoID");

                entity.Property(e => e.NumeroTelefono).HasMaxLength(25);

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.Telefono)
                    .HasForeignKey(d => d.PersonaId);
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
