using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Producto
{
    public int ProductoId { get; set; }

    public decimal Coste { get; set; }

    public int DiasFabricacion { get; set; }

    public DateTime? FechaFinVenta { get; set; }

    public DateTime FechaInicioVenta { get; set; }

    public DateTime? FechaRetirada { get; set; }

    public string Mpn { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public decimal PrecioVenta { get; set; }

    public int? ProductoModeloId { get; set; }

    public int? ProductoSubcategoriaId { get; set; }

    public short PuntoPedido { get; set; }

    public short StockDeSeguridad { get; set; }

    public virtual ICollection<PedidoVentaDetalle> PedidoVentaDetalles { get; set; } = new List<PedidoVentaDetalle>();

    public virtual ICollection<ProductoInventario> ProductoInventarios { get; set; } = new List<ProductoInventario>();

    public virtual ProductoModelo? ProductoModelo { get; set; }

    public virtual ProductoSubcategorium? ProductoSubcategoria { get; set; }
}
