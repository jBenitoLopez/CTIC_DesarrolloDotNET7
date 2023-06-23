using System;
using System.Collections.Generic;

namespace DEMO_EntityF.Entidades
{
    public partial class Comercial
    {
        public Comercial()
        {
            PedidoVenta = new HashSet<PedidoVenta>();
        }

        public int PersonaId { get; set; }
        public decimal Bonus { get; set; }
        public decimal? CuotaVentas { get; set; }
        public decimal PorcentajeComision { get; set; }

        public virtual Persona? Persona { get; set; }
        public virtual ICollection<PedidoVenta> PedidoVenta { get; set; }
    }
}
