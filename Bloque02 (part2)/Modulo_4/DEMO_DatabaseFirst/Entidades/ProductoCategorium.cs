using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class ProductoCategorium
{
    public int ProductoCategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ProductoSubcategorium> ProductoSubcategoria { get; set; } = new List<ProductoSubcategorium>();
}
