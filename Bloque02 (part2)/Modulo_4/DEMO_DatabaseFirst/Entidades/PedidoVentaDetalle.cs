using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class PedidoVentaDetalle
{
    public int PedidoVentaDetalleId { get; set; }

    public short Cantidad { get; set; }

    public decimal DescuentoPrecioUnitario { get; set; }

    public string? NumeroSeguimiento { get; set; }

    public int PedidoVentaId { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int ProductoId { get; set; }

    public virtual PedidoVentum PedidoVenta { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
