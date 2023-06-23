using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Direccion
{
    public int DireccionId { get; set; }

    public string Ciudad { get; set; } = null!;

    public int ClienteId { get; set; }

    public string CodigoPostal { get; set; } = null!;

    public string Linea1 { get; set; } = null!;

    public string? Linea2 { get; set; }

    public int ProvinciaId { get; set; }

    public virtual Persona Cliente { get; set; } = null!;

    public virtual ICollection<PedidoVentum> PedidoVentumDireccionEnvios { get; set; } = new List<PedidoVentum>();

    public virtual ICollection<PedidoVentum> PedidoVentumDireccionFacturacions { get; set; } = new List<PedidoVentum>();

    public virtual Provincium Provincia { get; set; } = null!;
}
