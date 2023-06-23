using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Persona
{
    public string? EstadoCivil { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? NumeroIdentificacion { get; set; }

    public string? Puesto { get; set; }

    public int PersonaId { get; set; }

    public string Apellidos { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public string? InformacionAdicional { get; set; }

    public string Nombre { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public virtual Comercial? Comercial { get; set; }

    public virtual ICollection<DireccionEmail> DireccionEmails { get; set; } = new List<DireccionEmail>();

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();

    public virtual ICollection<PedidoVentum> PedidoVenta { get; set; } = new List<PedidoVentum>();

    public virtual ICollection<TarjetaCredito> TarjetaCreditos { get; set; } = new List<TarjetaCredito>();

    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
}
