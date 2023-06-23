using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class TarjetaCredito
{
    public int TarjetaCreditoId { get; set; }

    public short AnnoExpiracion { get; set; }

    public byte MesExpiracion { get; set; }

    public string Numero { get; set; } = null!;

    public int PersonaId { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<PedidoVentum> PedidoVenta { get; set; } = new List<PedidoVentum>();

    public virtual Persona Persona { get; set; } = null!;
}
