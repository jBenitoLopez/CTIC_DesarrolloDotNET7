using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class ProductoModelo
    {
        public ProductoModelo()
        {
            Producto = new HashSet<Producto>();
        }

        public int ProductoModeloId { get; set; }
        public string DescripcionCatalogo { get; set; }
        public string Instrucciones { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
