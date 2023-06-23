using System;
using System.Collections.Generic;
using DEMO_DatabaseFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DEMO_DatabaseFirst.Contexto;

public partial class AppDatosContext : DbContext
{
    public AppDatosContext()
    {
    }

    public AppDatosContext(DbContextOptions<AppDatosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comercial> Comercials { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<DireccionEmail> DireccionEmails { get; set; }

    public virtual DbSet<FormaEnvio> FormaEnvios { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<PedidoVentaDetalle> PedidoVentaDetalles { get; set; }

    public virtual DbSet<PedidoVentum> PedidoVenta { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoCategorium> ProductoCategoria { get; set; }

    public virtual DbSet<ProductoInventario> ProductoInventarios { get; set; }

    public virtual DbSet<ProductoModelo> ProductoModelos { get; set; }

    public virtual DbSet<ProductoSubcategorium> ProductoSubcategoria { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<TarjetaCredito> TarjetaCreditos { get; set; }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Encrypt=false;Data Source=BPO2204-408\\SQL2019;Initial Catalog=AppDatos;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AI");

        modelBuilder.Entity<Comercial>(entity =>
        {
            entity.HasKey(e => e.PersonaId);

            entity.ToTable("Comercial");

            entity.Property(e => e.PersonaId)
                .ValueGeneratedNever()
                .HasColumnName("PersonaID");
            entity.Property(e => e.Bonus).HasColumnType("money");
            entity.Property(e => e.CuotaVentas).HasColumnType("money");
            entity.Property(e => e.PorcentajeComision).HasColumnType("smallmoney");

            entity.HasOne(d => d.Persona).WithOne(p => p.Comercial)
                .HasForeignKey<Comercial>(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.ToTable("Direccion");

            entity.HasIndex(e => e.ClienteId, "IX_Direccion_ClienteID");

            entity.HasIndex(e => e.ProvinciaId, "IX_Direccion_ProvinciaID");

            entity.Property(e => e.DireccionId).HasColumnName("DireccionID");
            entity.Property(e => e.Ciudad).HasMaxLength(30);
            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.CodigoPostal).HasMaxLength(15);
            entity.Property(e => e.Linea1).HasMaxLength(60);
            entity.Property(e => e.Linea2).HasMaxLength(60);
            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Direccions).HasForeignKey(d => d.ClienteId);

            entity.HasOne(d => d.Provincia).WithMany(p => p.Direccions)
                .HasForeignKey(d => d.ProvinciaId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DireccionEmail>(entity =>
        {
            entity.ToTable("DireccionEmail");

            entity.HasIndex(e => e.PersonaId, "IX_DireccionEmail_PersonaID");

            entity.Property(e => e.DireccionEmailId).HasColumnName("DireccionEmailID");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

            entity.HasOne(d => d.Persona).WithMany(p => p.DireccionEmails).HasForeignKey(d => d.PersonaId);
        });

        modelBuilder.Entity<FormaEnvio>(entity =>
        {
            entity.ToTable("FormaEnvio");

            entity.Property(e => e.FormaEnvioId).HasColumnName("FormaEnvioID");
            entity.Property(e => e.Coste).HasColumnType("money");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.PaisId);

            entity.Property(e => e.PaisId)
                .HasMaxLength(3)
                .HasColumnName("PaisID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<PedidoVentaDetalle>(entity =>
        {
            entity.ToTable("PedidoVentaDetalle");

            entity.HasIndex(e => e.PedidoVentaId, "IX_PedidoVentaDetalle_PedidoVentaID");

            entity.HasIndex(e => e.ProductoId, "IX_PedidoVentaDetalle_ProductoID");

            entity.Property(e => e.PedidoVentaDetalleId).HasColumnName("PedidoVentaDetalleID");
            entity.Property(e => e.DescuentoPrecioUnitario).HasColumnType("money");
            entity.Property(e => e.NumeroSeguimiento).HasMaxLength(25);
            entity.Property(e => e.PedidoVentaId).HasColumnName("PedidoVentaID");
            entity.Property(e => e.PrecioUnitario).HasColumnType("money");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");

            entity.HasOne(d => d.PedidoVenta).WithMany(p => p.PedidoVentaDetalles).HasForeignKey(d => d.PedidoVentaId);

            entity.HasOne(d => d.Producto).WithMany(p => p.PedidoVentaDetalles).HasForeignKey(d => d.ProductoId);
        });

        modelBuilder.Entity<PedidoVentum>(entity =>
        {
            entity.HasKey(e => e.PedidoVentaId);

            entity.HasIndex(e => e.ClienteId, "IX_PedidoVenta_ClienteID");

            entity.HasIndex(e => e.ComercialId, "IX_PedidoVenta_ComercialID");

            entity.HasIndex(e => e.DireccionEnvioId, "IX_PedidoVenta_DireccionEnvioID");

            entity.HasIndex(e => e.DireccionFacturacionId, "IX_PedidoVenta_DireccionFacturacionID");

            entity.HasIndex(e => e.FormaEnvioId, "IX_PedidoVenta_FormaEnvioID");

            entity.HasIndex(e => e.TarjetaCreditoId, "IX_PedidoVenta_TarjetaCreditoID");

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

            entity.HasOne(d => d.Cliente).WithMany(p => p.PedidoVenta).HasForeignKey(d => d.ClienteId);

            entity.HasOne(d => d.Comercial).WithMany(p => p.PedidoVenta).HasForeignKey(d => d.ComercialId);

            entity.HasOne(d => d.DireccionEnvio).WithMany(p => p.PedidoVentumDireccionEnvios).HasForeignKey(d => d.DireccionEnvioId);

            entity.HasOne(d => d.DireccionFacturacion).WithMany(p => p.PedidoVentumDireccionFacturacions).HasForeignKey(d => d.DireccionFacturacionId);

            entity.HasOne(d => d.FormaEnvio).WithMany(p => p.PedidoVenta).HasForeignKey(d => d.FormaEnvioId);

            entity.HasOne(d => d.TarjetaCredito).WithMany(p => p.PedidoVenta).HasForeignKey(d => d.TarjetaCreditoId);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.ToTable("Persona");

            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.Apellidos).HasMaxLength(50);
            entity.Property(e => e.EstadoCivil).HasMaxLength(1);
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.Genero).HasMaxLength(1);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NumeroIdentificacion).HasMaxLength(15);
            entity.Property(e => e.Puesto).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(2);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.HasIndex(e => e.ProductoModeloId, "IX_Producto_ProductoModeloID");

            entity.HasIndex(e => e.ProductoSubcategoriaId, "IX_Producto_ProductoSubcategoriaID");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Coste).HasColumnType("money");
            entity.Property(e => e.Mpn).HasMaxLength(25);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.PrecioVenta).HasColumnType("money");
            entity.Property(e => e.ProductoModeloId).HasColumnName("ProductoModeloID");
            entity.Property(e => e.ProductoSubcategoriaId).HasColumnName("ProductoSubcategoriaID");

            entity.HasOne(d => d.ProductoModelo).WithMany(p => p.Productos).HasForeignKey(d => d.ProductoModeloId);

            entity.HasOne(d => d.ProductoSubcategoria).WithMany(p => p.Productos).HasForeignKey(d => d.ProductoSubcategoriaId);
        });

        modelBuilder.Entity<ProductoCategorium>(entity =>
        {
            entity.HasKey(e => e.ProductoCategoriaId);

            entity.Property(e => e.ProductoCategoriaId).HasColumnName("ProductoCategoriaID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductoInventario>(entity =>
        {
            entity.HasKey(e => new { e.ProductoId, e.UbicacionId });

            entity.ToTable("ProductoInventario");

            entity.HasIndex(e => e.UbicacionId, "IX_ProductoInventario_UbicacionID");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");
            entity.Property(e => e.Shelf).HasMaxLength(10);

            entity.HasOne(d => d.Producto).WithMany(p => p.ProductoInventarios).HasForeignKey(d => d.ProductoId);

            entity.HasOne(d => d.Ubicacion).WithMany(p => p.ProductoInventarios).HasForeignKey(d => d.UbicacionId);
        });

        modelBuilder.Entity<ProductoModelo>(entity =>
        {
            entity.ToTable("ProductoModelo");

            entity.Property(e => e.ProductoModeloId).HasColumnName("ProductoModeloID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductoSubcategorium>(entity =>
        {
            entity.HasKey(e => e.ProductoSubcategoriaId);

            entity.HasIndex(e => e.ProductoCategoriaId, "IX_ProductoSubcategoria_ProductoCategoriaID");

            entity.Property(e => e.ProductoSubcategoriaId).HasColumnName("ProductoSubcategoriaID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.ProductoCategoriaId).HasColumnName("ProductoCategoriaID");

            entity.HasOne(d => d.ProductoCategoria).WithMany(p => p.ProductoSubcategoria).HasForeignKey(d => d.ProductoCategoriaId);
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProvinciaId);

            entity.HasIndex(e => e.PaisId, "IX_Provincia_PaisID");

            entity.Property(e => e.ProvinciaId).HasColumnName("ProvinciaID");
            entity.Property(e => e.CodigoProvincia).HasMaxLength(3);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.PaisId)
                .HasMaxLength(3)
                .HasColumnName("PaisID");

            entity.HasOne(d => d.Pais).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TarjetaCredito>(entity =>
        {
            entity.ToTable("TarjetaCredito");

            entity.HasIndex(e => e.PersonaId, "IX_TarjetaCredito_PersonaID");

            entity.Property(e => e.TarjetaCreditoId).HasColumnName("TarjetaCreditoID");
            entity.Property(e => e.Numero).HasMaxLength(25);
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");
            entity.Property(e => e.Tipo).HasMaxLength(50);

            entity.HasOne(d => d.Persona).WithMany(p => p.TarjetaCreditos).HasForeignKey(d => d.PersonaId);
        });

        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.ToTable("Telefono");

            entity.HasIndex(e => e.PersonaId, "IX_Telefono_PersonaID");

            entity.Property(e => e.TelefonoId).HasColumnName("TelefonoID");
            entity.Property(e => e.NumeroTelefono).HasMaxLength(25);
            entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

            entity.HasOne(d => d.Persona).WithMany(p => p.Telefonos).HasForeignKey(d => d.PersonaId);
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.ToTable("Ubicacion");

            entity.Property(e => e.UbicacionId).HasColumnName("UbicacionID");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
