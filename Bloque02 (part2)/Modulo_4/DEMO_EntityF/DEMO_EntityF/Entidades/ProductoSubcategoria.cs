using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class ProductoSubcategoria
    {
        public ProductoSubcategoria()
        {
            Producto = new HashSet<Producto>();
        }

        public int ProductoSubcategoriaId { get; set; }
        public string Nombre { get; set; }
        public int ProductoCategoriaId { get; set; }

        public virtual ProductoCategoria ProductoCategoria { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
