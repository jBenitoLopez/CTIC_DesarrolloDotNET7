using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            ProductoInventario = new HashSet<ProductoInventario>();
        }

        public short UbicacionId { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ProductoInventario> ProductoInventario { get; set; }
    }
}
