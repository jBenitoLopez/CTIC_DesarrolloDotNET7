using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Ubicacion
{
    public short UbicacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ProductoInventario> ProductoInventarios { get; set; } = new List<ProductoInventario>();
}
