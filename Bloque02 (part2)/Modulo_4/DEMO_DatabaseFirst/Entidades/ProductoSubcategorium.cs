using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class ProductoSubcategorium
{
    public int ProductoSubcategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int ProductoCategoriaId { get; set; }

    public virtual ProductoCategorium ProductoCategoria { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
