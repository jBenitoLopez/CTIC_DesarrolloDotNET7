using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Producto
    {
        public Producto()
        {
            PedidoVentaDetalle = new HashSet<PedidoVentaDetalle>();
            ProductoInventario = new HashSet<ProductoInventario>();
        }

        public int ProductoId { get; set; }
        public decimal Coste { get; set; }
        public int DiasFabricacion { get; set; }
        public DateTime? FechaFinVenta { get; set; }
        public DateTime FechaInicioVenta { get; set; }
        public DateTime? FechaRetirada { get; set; }
        public string? Mpn { get; set; }
        public string? Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int? ProductoModeloId { get; set; }
        public int? ProductoSubcategoriaId { get; set; }
        public short PuntoPedido { get; set; }
        public short StockDeSeguridad { get; set; }

        public virtual ProductoModelo? ProductoModelo { get; set; }
        public virtual ProductoSubcategoria? ProductoSubcategoria { get; set; }
        public virtual ICollection<PedidoVentaDetalle>? PedidoVentaDetalle { get; set; }
        public virtual ICollection<ProductoInventario>? ProductoInventario { get; set; }
    }
}
