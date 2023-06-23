using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class ProductoInventario
    {
        public int ProductoId { get; set; }
        public short UbicacionId { get; set; }
        public short Cantidad { get; set; }
        public string Shelf { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}
