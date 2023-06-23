using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class ProductoModelo
{
    public int ProductoModeloId { get; set; }

    public string? DescripcionCatalogo { get; set; }

    public string? Instrucciones { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
