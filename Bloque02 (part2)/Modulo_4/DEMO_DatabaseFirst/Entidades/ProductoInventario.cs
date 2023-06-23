using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class ProductoInventario
{
    public int ProductoId { get; set; }

    public short UbicacionId { get; set; }

    public short Cantidad { get; set; }

    public string Shelf { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;

    public virtual Ubicacion Ubicacion { get; set; } = null!;
}
