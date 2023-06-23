using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class FormaEnvio
{
    public int FormaEnvioId { get; set; }

    public decimal Coste { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<PedidoVentum> PedidoVenta { get; set; } = new List<PedidoVentum>();
}
