using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class PedidoVentum
{
    public int PedidoVentaId { get; set; }

    public int ClienteId { get; set; }

    public string? CodigoAutorizacion { get; set; }

    public string? Comentario { get; set; }

    public int? ComercialId { get; set; }

    public int? DireccionEnvioId { get; set; }

    public int? DireccionFacturacionId { get; set; }

    public decimal Envio { get; set; }

    public byte Estado { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public DateTime FechaPedido { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public int FormaEnvioId { get; set; }

    public string? ReferenciaCliente { get; set; }

    public decimal SubTotal { get; set; }

    public int? TarjetaCreditoId { get; set; }

    public virtual Persona Cliente { get; set; } = null!;

    public virtual Comercial? Comercial { get; set; }

    public virtual Direccion? DireccionEnvio { get; set; }

    public virtual Direccion? DireccionFacturacion { get; set; }

    public virtual FormaEnvio FormaEnvio { get; set; } = null!;

    public virtual ICollection<PedidoVentaDetalle> PedidoVentaDetalles { get; set; } = new List<PedidoVentaDetalle>();

    public virtual TarjetaCredito? TarjetaCredito { get; set; }
}
