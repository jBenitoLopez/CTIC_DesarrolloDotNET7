using System;
using System.Collections.Generic;

namespace DEMO_DatabaseFirst.Entidades;

public partial class Comercial
{
    public int PersonaId { get; set; }

    public decimal Bonus { get; set; }

    public decimal? CuotaVentas { get; set; }

    public decimal PorcentajeComision { get; set; }

    public virtual ICollection<PedidoVentum> PedidoVenta { get; set; } = new List<PedidoVentum>();

    public virtual Persona Persona { get; set; } = null!;
}
