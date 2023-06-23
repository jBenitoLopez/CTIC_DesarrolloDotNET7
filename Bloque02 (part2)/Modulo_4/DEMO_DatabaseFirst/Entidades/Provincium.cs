using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Provincium
{
    public int ProvinciaId { get; set; }

    public string CodigoProvincia { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string PaisId { get; set; } = null!;

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();

    public virtual Pai Pais { get; set; } = null!;
}
