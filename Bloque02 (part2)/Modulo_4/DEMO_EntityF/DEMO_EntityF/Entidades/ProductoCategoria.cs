using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class ProductoCategoria
    {
        public ProductoCategoria()
        {
            ProductoSubcategoria = new HashSet<ProductoSubcategoria>();
        }

        public int ProductoCategoriaId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ProductoSubcategoria> ProductoSubcategoria { get; set; }
    }
}
